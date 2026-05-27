
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Create
{
    public class CreatePolishingCostCommandHandler : IRequestHandler<CreatePolishingCostCommandRequest, CreatePolishingCostCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreatePolishingCostCommandHandler(IUnitOfWork unitOfWork) { _unitOfWork = unitOfWork; }
        public async Task<CreatePolishingCostCommandResponse> Handle(CreatePolishingCostCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new PolishingCost
            {
                CategoryId = request.CategoryId,
                CostPrice = request.CostPrice,
            };
            await _unitOfWork.GetWriteRepository<PolishingCost>().AddAsync(entity);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new CreatePolishingCostCommandResponse { Success = true, Message = "Eklendi." };
        }
    }
}
