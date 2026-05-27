using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.ProductStoneFeature.Commands.Delete
{
    public class DeleteProductStoneCommandHandler : IRequestHandler<DeleteProductStoneCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProductStoneCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(DeleteProductStoneCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<KatalogApp.Domain.Entities.ProductStone>().GetAsync(x => x.Id == request.Id);
            if (entity == null) return new ResponseDto<bool>().Fail("Silinecek taş bulunamadı.");
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.ProductStone>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<bool>().Success(true);
        }
    }
}
