using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using KatalogApp.Application.Interfaces.Services;
using System.Linq;

namespace KatalogApp.Application.Features.ProductsFeature.Queries.GetProductByCategoryId
{
    public class GetProductByCategoryIdQueryHandler : IRequestHandler<GetProductByCategoryIdQueryRequest, ResponseDto<List<GetProductByCategoryIdQueryResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPricingService _pricingService;

        public GetProductByCategoryIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IPricingService pricingService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _pricingService = pricingService;
        }

        public async Task<ResponseDto<List<GetProductByCategoryIdQueryResponse>>> Handle(GetProductByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.GetReadRepository<Products>().GetAllAsync(
                predicate: x => !x.IsDeleted && x.Categories.Any(c => c.Id == request.CategoryId),
                include: q => q
                    .Include(p => p.Categories)
                    .Include(p => p.MetalPurity)
                    .Include(p => p.MetalColor)
                    .Include(p => p.Images)
                    .Include(p => p.ProductStones).ThenInclude(ps => ps.Stone).ThenInclude(s => s.StoneScale)
                    .Include(p => p.ProductStones).ThenInclude(ps => ps.Color)
                    .Include(p => p.ProductStones).ThenInclude(ps => ps.Clarity)
                    .Include(p => p.ProductMetals).ThenInclude(pm => pm.MetalType)
                    .Include(p => p.ProductMetals).ThenInclude(pm => pm.MetalPurity)
                    ,
                ct: cancellationToken
            );

            var result = _mapper.Map<List<GetProductByCategoryIdQueryResponse>>(products);

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

            var customPrices = await _pricingService.CalculateCustomerPricesAsync(products.ToList(), currentUserId);

            foreach (var item in result)
            {
                item.CalculatedPrice = customPrices.ContainsKey(item.Id) ? customPrices[item.Id] : 0;
                
                // Keep image paths formatting
                var prod = products.FirstOrDefault(p => p.Id == item.Id);
                if (prod != null && prod.Images != null)
                {
                    item.Images = prod.Images.Select(img => img.ImageName).ToList();
                }
            }
            
            return new ResponseDto<List<GetProductByCategoryIdQueryResponse>>().Success(result);
        }
    }
}
