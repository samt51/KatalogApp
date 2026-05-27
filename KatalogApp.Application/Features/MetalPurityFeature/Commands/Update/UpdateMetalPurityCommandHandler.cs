using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.MetalPurityFeature.Commands.Update
{
    public class UpdateMetalPurityCommandHandler : IRequestHandler<UpdateMetalPurityCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateMetalPurityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateMetalPurityCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.MetalPurity>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.ModifyDate = System.DateTime.Now;
            entity.Name = request.Name;
            entity.Milyem = request.Milyem;
            entity.Density = request.Density;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.MetalPurity>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
