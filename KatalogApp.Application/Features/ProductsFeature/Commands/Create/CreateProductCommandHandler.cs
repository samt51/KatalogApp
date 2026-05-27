using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Interfaces.Services;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPricingService _pricingService;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IPricingService pricingService)
        {
            _unitOfWork = unitOfWork;
            _pricingService = pricingService;
        }

        public async Task<ResponseDto<bool>> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var exists = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Products>().FindAsync(x => x.Code == request.Code&&!x.IsDeleted);
            if (exists != null)
            {
                throw new System.Exception("Bu ürün kodu ile daha önce bir ürün eklenmiş!");
            }

            var entity = new KatalogApp.Domain.Entities.Products 
            { 
                CreatedDate = System.DateTime.Now,
                Code = request.Code,
                Name = request.Name,
                Description = request.Description ?? "",
                ImageName = (request.ImageNames != null && request.ImageNames.Count > 0) ? request.ImageNames[0] : "",
                Gram = request.Gram,
                MetalPurityId = request.MetalPurityId,
                DiamondCarat = request.DiamondCarat,
                CategoryId = request.CategoryId,
                MetalColorId = request.MetalColorId,
                LaborMultiplier = request.LaborMultiplier,
                PolishingCost = request.PolishingCost,
                LiveGoldPrice = request.LiveGoldPrice,
                CurrencyId = 1
            };
            
            if (request.ProductStones != null && request.ProductStones.Count > 0)
            {
                foreach (var stone in request.ProductStones)
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
                entity.DiamondCarat = entity.ProductStones.Sum(s => s.TotalCarat);
            }
            else
            {
                entity.DiamondCarat = 0;
            }

            if (request.ProductMetals != null && request.ProductMetals.Count > 0)
            {
                foreach (var metal in request.ProductMetals)
                {
                    entity.ProductMetals.Add(new KatalogApp.Domain.Entities.ProductMetal
                    {
                        MetalTypeId = metal.MetalTypeId,
                        MetalPurityId = request.MetalPurityId ?? 1,
                        Weight = metal.Weight,
                        CreatedDate = System.DateTime.Now
                    });
                }
            }

            if (request.ImageNames != null && request.ImageNames.Count > 0)
            {
                foreach (var img in request.ImageNames)
                {
                    entity.Images.Add(new KatalogApp.Domain.Entities.ProductImage
                    {
                        ImageName = img,
                        CreatedDate = System.DateTime.Now
                    });
                }
            }

            // Ürün oluşturulduğunda maliyetlerini (Altın, İşçilik vb.) ve eklenen taş maliyetlerini hesaplayıp statik alanlara kaydet
            await _pricingService.CalculatePriceAsync(entity);

            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.Products>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<bool>().Success(true);
        }
    }
}


