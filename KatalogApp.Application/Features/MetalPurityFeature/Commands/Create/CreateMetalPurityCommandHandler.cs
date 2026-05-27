using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.MetalPurityFeature.Commands.Create
{
    public class CreateMetalPurityCommandHandler : IRequestHandler<CreateMetalPurityCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateMetalPurityCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateMetalPurityCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new KatalogApp.Domain.Entities.MetalPurity { CreatedDate = System.DateTime.Now };
            entity.Name = request.Name;
            entity.Milyem = request.Milyem;
            entity.Density = request.Density;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.MetalPurity>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
