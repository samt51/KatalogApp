using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Update
{
    public class UpdateStoneSettingCommandHandler : IRequestHandler<UpdateStoneSettingCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStoneSettingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateStoneSettingCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneSetting>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;

            entity.UnitId = request.UnitId;
            entity.SettingPrice = request.SettingPrice;
            entity.ModifyDate = System.DateTime.Now;

            _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.StoneSetting>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
