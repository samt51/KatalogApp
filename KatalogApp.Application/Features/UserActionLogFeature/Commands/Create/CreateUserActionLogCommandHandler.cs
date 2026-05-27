using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Domain.Entities;

namespace KatalogApp.Application.Features.UserActionLogFeature.Commands.Create
{
    public class CreateUserActionLogCommandHandler : IRequestHandler<CreateUserActionLogCommandRequest, KatalogApp.Application.Core.Dtos.ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserActionLogCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<KatalogApp.Application.Core.Dtos.ResponseDto<bool>> Handle(CreateUserActionLogCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new UserActionLog
            {
                UserId = request.UserId,
                ActionType = request.ActionType,
                ProductId = request.ProductId,
                Details = request.Details,
                IpAddress = request.IpAddress,
                UserAgent = request.UserAgent
            };
            
            await _unitOfWork.GetWriteRepository<UserActionLog>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new KatalogApp.Application.Core.Dtos.ResponseDto<bool>().Success(true);
        }
    }
}
