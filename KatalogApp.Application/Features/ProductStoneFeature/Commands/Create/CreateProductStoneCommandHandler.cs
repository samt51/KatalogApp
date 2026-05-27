using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Commands.Create
{
    public class CreateProductStoneCommandHandler : IRequestHandler<CreateProductStoneCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateProductStoneCommandHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }

        public async Task<ResponseDto<bool>> Handle(CreateProductStoneCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new ProductStone 
            { 
                ProductId = request.ProductId,
                StoneId = request.StoneId,
                Quantity = request.Quantity,
                Carat = request.Carat,
                TotalCarat = request.TotalCarat,
                CreatedDate = System.DateTime.Now
            };
            await _unitOfWork.GetWriteRepository<ProductStone>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }
    }
}
