using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Interfaces.Services;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPricingService _pricingService;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IPricingService pricingService)
        {
            _unitOfWork = unitOfWork;
            _pricingService = pricingService;
        }

        public async Task<ResponseDto<bool>> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.Products>();
            var readRepo = _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Products>();
            
            // Taşları, madenleri ve resimleri dahil ederek ürünü çekiyoruz
            var entity = await readRepo.GetAsync(
                p => p.Id == request.Id,
                include: q => q.Include(x => x.ProductStones).ThenInclude(ps => ps.Stone)
                               .Include(x => x.ProductMetals)
                               .Include(x => x.Images)
            );
            if(entity == null) return new ResponseDto<bool>().Fail("Ürün bulunamadı");

            entity.Code = request.Code;
            entity.Name = request.Name;
            entity.Description = request.Description ?? "";
            entity.Gram = request.Gram;
            entity.MetalPurityId = request.MetalPurityId;
            entity.DiamondCarat = request.DiamondCarat;
            entity.CategoryId = request.CategoryId;
            entity.MetalColorId = request.MetalColorId;
            entity.LaborMultiplier = request.LaborMultiplier;
            entity.PolishingCost = request.PolishingCost;
            entity.LiveGoldPrice = request.LiveGoldPrice;
            entity.ModifyDate = System.DateTime.Now;

            // Update Stones
            if (request.ProductStones != null)
            {
                // Soft delete stones not in request
                foreach (var existing in entity.ProductStones.Where(x => !x.IsDeleted))
                {
                    if (!request.ProductStones.Any(s => s.Id == existing.Id))
                    {
                        existing.IsDeleted = true;
                        existing.ModifyDate = System.DateTime.Now;
                    }
                }
                
                // Add or update stones
                foreach (var stone in request.ProductStones)
                {
                    if (stone.Id == 0)
                    {
                        entity.ProductStones.Add(new KatalogApp.Domain.Entities.ProductStone
                        {
                            StoneId = stone.StoneId,
                            Quantity = stone.Quantity,
                            Carat = stone.Carat,
                            TotalCarat = stone.TotalCarat,
                            ClarityId = stone.ClarityId,
                            ColorId = stone.ColorId,
                            CreatedDate = System.DateTime.Now
                        });
                    }
                    else
                    {
                        var existing = entity.ProductStones.FirstOrDefault(x => x.Id == stone.Id);
                        if (existing != null)
                        {
                            existing.StoneId = stone.StoneId;
                            existing.Quantity = stone.Quantity;
                            existing.Carat = stone.Carat;
                            existing.TotalCarat = stone.TotalCarat;
                            existing.ClarityId = stone.ClarityId;
                            existing.ColorId = stone.ColorId;
                            existing.ModifyDate = System.DateTime.Now;
                        }
                    }
                }
            }
            
            entity.DiamondCarat = entity.ProductStones != null ? entity.ProductStones.Where(s => !s.IsDeleted).Sum(s => s.TotalCarat) : 0;

            // Update Metals
            if (request.ProductMetals != null)
            {
                // Soft delete metals not in request
                foreach (var existing in entity.ProductMetals.Where(x => !x.IsDeleted))
                {
                    if (!request.ProductMetals.Any(m => m.Id == existing.Id))
                    {
                        existing.IsDeleted = true;
                        existing.ModifyDate = System.DateTime.Now;
                    }
                }
                
                // Add or update metals
                foreach (var metal in request.ProductMetals)
                {
                    if (metal.Id == 0)
                    {
                        entity.ProductMetals.Add(new KatalogApp.Domain.Entities.ProductMetal
                        {
                            MetalTypeId = metal.MetalTypeId,
                            MetalPurityId = request.MetalPurityId ?? 1,
                            Weight = metal.Weight,
                            CreatedDate = System.DateTime.Now
                        });
                    }
                    else
                    {
                        var existing = entity.ProductMetals.FirstOrDefault(x => x.Id == metal.Id);
                        if (existing != null)
                        {
                            existing.MetalTypeId = metal.MetalTypeId;
                            existing.Weight = metal.Weight;
                            existing.ModifyDate = System.DateTime.Now;
                        }
                    }
                }
            }

            // Update Images
            if (request.ImageNames != null && request.ImageNames.Count > 0)
            {
                entity.ImageName = request.ImageNames[0]; // Set main image

                // Delete all old ones permanently, or soft delete? We'll just keep adding new ones or clear.
                // Wait, if ImageNames contains new images, we just append them! We already have an API to delete images individually, or we can manage them together.
                // Assuming ImageNames only contains newly uploaded images.
                foreach (var img in request.ImageNames)
                {
                    entity.Images.Add(new KatalogApp.Domain.Entities.ProductImage
                    {
                        ImageName = img,
                        CreatedDate = System.DateTime.Now
                    });
                }
            }
            
            // Ürün özellikleri değiştiği için maliyetleri tekrar hesaplayıp statik alanlara kaydet
            await _pricingService.CalculatePriceAsync(entity);

            await repo.UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<bool>().Success(true);
        }
    }
}


