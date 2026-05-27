using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductMetalFeature.Commands.Delete
{
    public class DeleteProductMetalCommandHandler : IRequestHandler<DeleteProductMetalCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductMetalCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(DeleteProductMetalCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductMetal>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return new ResponseDto<bool>().Fail("Silinecek maden bulunamadı.");
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.ProductMetal>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }
    }
}
