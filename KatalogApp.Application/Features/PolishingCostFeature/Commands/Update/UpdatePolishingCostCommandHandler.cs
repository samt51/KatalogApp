
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Update
{
    public class UpdatePolishingCostCommandHandler : IRequestHandler<UpdatePolishingCostCommandRequest, UpdatePolishingCostCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdatePolishingCostCommandHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }
        public async Task<UpdatePolishingCostCommandResponse> Handle(UpdatePolishingCostCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<PolishingCost>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return new UpdatePolishingCostCommandResponse { Success = false, Message = "Bulunamadı." };
            
            entity.CategoryId = request.CategoryId;
            entity.CostPrice = request.CostPrice;
            
            _unitOfWork.GetWriteRepository<PolishingCost>().UpdateAsync(entity);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new UpdatePolishingCostCommandResponse { Success = true, Message = "Güncellendi." };
        }
    }
}
