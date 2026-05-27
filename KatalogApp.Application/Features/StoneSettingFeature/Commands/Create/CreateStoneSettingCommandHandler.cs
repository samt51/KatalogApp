using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Create
{
    public class CreateStoneSettingCommandHandler : IRequestHandler<CreateStoneSettingCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateStoneSettingCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateStoneSettingCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new KatalogApp.Domain.Entities.StoneSetting { CreatedDate = System.DateTime.Now };
            entity.UnitId = request.UnitId;
            entity.SettingPrice = request.SettingPrice;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.StoneSetting>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
