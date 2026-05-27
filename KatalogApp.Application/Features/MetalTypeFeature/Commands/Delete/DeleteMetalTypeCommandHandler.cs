using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.MetalTypeFeature.Commands.Delete
{
    public class DeleteMetalTypeCommandHandler : IRequestHandler<DeleteMetalTypeCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteMetalTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteMetalTypeCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.MetalType>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.MetalType>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
