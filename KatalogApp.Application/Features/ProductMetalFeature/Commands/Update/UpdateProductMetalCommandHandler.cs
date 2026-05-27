using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;

namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Update
{
    public class UpdateProductMetalCommandHandler : IRequestHandler<UpdateProductMetalCommandRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProductMetalCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateProductMetalCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductMetal>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return false;
            
            entity.ModifyDate = System.DateTime.Now;
            
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.ProductMetal>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return true;
        }
    }
}
