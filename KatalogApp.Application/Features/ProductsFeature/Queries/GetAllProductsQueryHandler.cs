using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Features.ProductsFeature.Dtos;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace KatalogApp.Application.Features.ProductsFeature.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, ResponseDto<List<ProductDto>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly KatalogApp.Application.Interfaces.Services.IPricingService _pricingService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, KatalogApp.Application.Interfaces.Services.IPricingService pricingService, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _pricingService = pricingService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<ResponseDto<List<ProductDto>>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var products = await _unitOfWork.GetReadRepository<Products>().GetAllAsync(
                    predicate: x => !x.IsDeleted,
                    include: q => q.Include(p => p.Categories)
                                   .Include(p => p.MetalPurity)
                                   .Include(p => p.ProductStones).ThenInclude(ps => ps.Stone).ThenInclude(s => s.StoneScale)
                                   .Include(p => p.ProductStones).ThenInclude(ps => ps.Color)
                                   .Include(p => p.ProductStones).ThenInclude(ps => ps.Clarity)
                                   .Include(p => p.ProductMetals).ThenInclude(pm => pm.MetalType)
                                   .Include(p => p.ProductMetals).ThenInclude(pm => pm.MetalPurity)
                                   .Include(p => p.Images),
                    ct: cancellationToken
                );

                int? currentUserId = null;
                var userIdClaim = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier);
                if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int uid))
                {
                    currentUserId = uid;
                }
                
                if (currentUserId == null)
                {
                    var authHeader = _httpContextAccessor.HttpContext?.Request?.Headers["Authorization"].ToString();
                    if (!string.IsNullOrEmpty(authHeader) && authHeader.StartsWith("Bearer ", System.StringComparison.OrdinalIgnoreCase))
                    {
                        var token = authHeader.Substring("Bearer ".Length).Trim();
                        var handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                        if (handler.CanReadToken(token))
                        {
                            var jwtToken = handler.ReadJwtToken(token);
                            var claimStr = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier || c.Type == "nameid" || c.Type == "sub")?.Value;
                            if (!string.IsNullOrEmpty(claimStr) && int.TryParse(claimStr, out int parsedUid))
                            {
                                currentUserId = parsedUid;
                            }
                        }
                    }
                }

                // Calculate custom prices in bulk
                var customPrices = await _pricingService.CalculateCustomerPricesAsync(products.ToList(), currentUserId);

                var result = new List<ProductDto>();
                var basePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "katalog");

                foreach (var p in products)
                {
                    var dto = new ProductDto
                    {
                        Id = p.Id,
                        Code = p.Code,
                        Name = p.Name,
                        ImageName = p.ImageName,
                        Description = p.Description,
                        Gram = p.Gram,
                        MetalPurityId = p.MetalPurityId,
                        MetalPurityName = p.MetalPurity?.Name ?? "",
                        DiamondCarat = p.DiamondCarat,
                        CategoryIds = p.Categories?.Select(c => c.Id).ToList() ?? new List<int>(),
                        CategoryNames = p.Categories?.Select(c => c.Name).ToList() ?? new List<string>(),
                        MetalColorId = p.MetalColorId,
                        LaborMultiplier = p.LaborMultiplier,
                        PolishingCost = p.PolishingCost,
                        LiveGoldPrice = p.LiveGoldPrice,
                        Images = p.Images?.Where(i => !i.IsDeleted).Select(i => i.ImageName).ToList() ?? new List<string>(),
                        ProductStones = p.ProductStones?.Where(ps => !ps.IsDeleted).Select(ps => new ProductStoneDto
                        {
                            Id = ps.Id,
                            StoneId = ps.StoneId,
                            StoneName = ps.Stone?.StoneScale?.Name ?? "",
                            Quantity = ps.Quantity,
                            Carat = ps.Carat,
                            TotalCarat = ps.TotalCarat, ClarityId = ps.ClarityId, ClarityName = ps.Clarity?.Name ?? "", ColorId = ps.ColorId, ColorName = ps.Color?.Name ?? ""
                        }).ToList() ?? new List<ProductStoneDto>(),
                        ProductMetals = p.ProductMetals?.Where(pm => !pm.IsDeleted).Select(pm => new ProductMetalDto
                        {
                            Id = pm.Id,
                            MetalTypeId = pm.MetalTypeId,
                            MetalTypeName = pm.MetalType?.Name ?? "",
                            MetalPurityId = pm.MetalPurityId,
                            MetalPurityName = pm.MetalPurity?.Name ?? "",
                            Gram = pm.Weight
                        }).ToList() ?? new List<ProductMetalDto>()
                    };

                    

                    // Assign custom calculated price or fallback to db totalcost
                    dto.CalculatedPrice = customPrices.ContainsKey(p.Id) ? customPrices[p.Id] : p.TotalCost;

                    result.Add(dto);
                }
                
                return new ResponseDto<List<ProductDto>>().Success(result);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
