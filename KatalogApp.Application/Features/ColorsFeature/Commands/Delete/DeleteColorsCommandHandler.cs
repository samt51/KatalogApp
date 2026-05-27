using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.ColorsFeature.Commands.Delete
{
    public class DeleteColorsCommandHandler : IRequestHandler<DeleteColorsCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteColorsCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteColorsCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Colors>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.Colors>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
