using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.StoneClarityFeature.Commands.Delete
{
    public class DeleteStoneClarityCommandHandler : IRequestHandler<DeleteStoneClarityCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStoneClarityCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteStoneClarityCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneClarity>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.StoneClarity>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
