using MediatR;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.ProductsFeature.Commands.Delete
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Products>().GetAsync(x => x.Id == request.Id);
            if (product == null)
            {
                return new ResponseDto<bool>().Fail("Ürün bulunamadý");
            }

            product.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<Products>().UpdateAsync(product);
            await _unitOfWork.SaveAsync();

            return new ResponseDto<bool>().Success(true);
        }
    }
}
