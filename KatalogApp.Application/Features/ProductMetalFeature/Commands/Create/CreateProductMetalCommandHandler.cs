using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Create
{
    public class CreateProductMetalCommandHandler : IRequestHandler<CreateProductMetalCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductMetalCommandHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }

        public async Task<ResponseDto<bool>> Handle(CreateProductMetalCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new ProductMetal 
            { 
                ProductId = request.ProductId,
                MetalTypeId = request.MetalTypeId,
                Weight = request.Gram,
                MetalPurityId = 1, // default if missing
                CreatedDate = System.DateTime.Now
            };
            await _unitOfWork.GetWriteRepository<ProductMetal>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }
    }
}

