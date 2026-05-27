using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.UnitsFeature.Commands.Update
{
    public class UpdateUnitsCommandHandler : IRequestHandler<UpdateUnitsCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUnitsCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateUnitsCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.Units>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.ModifyDate = System.DateTime.Now;
            entity.Name = request.Name;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.Units>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
