using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.StoneCutFeature.Commands.Create
{
    public class CreateStoneCutCommandHandler : IRequestHandler<CreateStoneCutCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStoneCutCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateStoneCutCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = new KatalogApp.Domain.Entities.StoneCut { CreatedDate = System.DateTime.Now };
            entity.Name = request.Name;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.StoneCut>().AddAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
