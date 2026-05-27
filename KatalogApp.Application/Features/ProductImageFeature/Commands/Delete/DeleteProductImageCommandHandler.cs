using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.ProductImageFeature.Commands.Delete
{
    public class DeleteProductImageCommandHandler : IRequestHandler<DeleteProductImageCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductImageCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteProductImageCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductImage>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.ProductImage>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
