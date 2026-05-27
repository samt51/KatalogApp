using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductImageFeature.Commands.Create
{
    public class CreateProductImageCommandHandler : IRequestHandler<CreateProductImageCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateProductImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(CreateProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new ProductImage 
            { 
                ProductId = request.ProductId,
                ImageName = request.ImageName,
                CreatedDate = System.DateTime.Now
            };
            
            await _unitOfWork.GetWriteRepository<ProductImage>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<bool>().Success(true);
        }
    }
}
