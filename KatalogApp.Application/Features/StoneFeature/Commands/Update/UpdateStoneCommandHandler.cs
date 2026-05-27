using MediatR;
using KatalogApp.Domain.Entities;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Core.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Update
{
    public class UpdateStoneCommandHandler : IRequestHandler<UpdateStoneCommandRequest, ResponseDto<UpdateStoneCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateStoneCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<UpdateStoneCommandResponse>> Handle(UpdateStoneCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<Stone>().GetAsync(x => x.Id == request.Id);
            if (entity == null) 
            {
                return new ResponseDto<UpdateStoneCommandResponse>().Fail("Kayıt bulunamadı.");
            }

            // Duplicate check removed since Name is removed

            entity.CostPrice = request.CostPrice;
            entity.StoneScaleId = request.StoneScaleId;
            entity.StoneTypeId = request.StoneTypeId;
            entity.UnitId = request.UnitId;
            entity.StoneSettingId = request.StoneSettingId;
            entity.StoneCutId = request.StoneCutId;
            entity.StoneClarityId = request.StoneClarityId;
            entity.ColorId = request.ColorId;
            
            entity.ModifyDate = System.DateTime.Now;
            
            await _unitOfWork.GetWriteRepository<Stone>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            
            return new ResponseDto<UpdateStoneCommandResponse>().Success();
        }
    }
}


