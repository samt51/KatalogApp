using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Delete
{
    public class DeleteStoneSettingCommandHandler : IRequestHandler<DeleteStoneSettingCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStoneSettingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteStoneSettingCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.StoneSetting>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;

            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;

            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.StoneSetting>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
