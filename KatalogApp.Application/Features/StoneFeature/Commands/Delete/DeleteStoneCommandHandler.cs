using System.Threading;
using System.Threading.Tasks;
using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Delete
{
    public class DeleteStoneCommandHandler : IRequestHandler<DeleteStoneCommandRequest, ResponseDto<DeleteStoneCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStoneCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<DeleteStoneCommandResponse>> Handle(DeleteStoneCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<Stone>().GetAsync(x => x.Id == request.Id);
            if (entity == null) 
            {
                return new ResponseDto<DeleteStoneCommandResponse>().Fail("Kayıt bulunamadı.");
            }
            
            entity.IsDeleted = true;
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<Stone>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<DeleteStoneCommandResponse>().Success();
        }
    }
}
