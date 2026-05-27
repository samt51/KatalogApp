
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Delete
{
    public class DeletePolishingCostCommandHandler : IRequestHandler<DeletePolishingCostCommandRequest, DeletePolishingCostCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeletePolishingCostCommandHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }
        public async Task<DeletePolishingCostCommandResponse> Handle(DeletePolishingCostCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<PolishingCost>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return new DeletePolishingCostCommandResponse { Success = false, Message = "Bulunamadı." };
            
            entity.IsDeleted = true;
            await _unitOfWork.GetWriteRepository<PolishingCost>().UpdateAsync(entity);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new DeletePolishingCostCommandResponse { Success = true, Message = "Silindi." };
        }
    }
}
