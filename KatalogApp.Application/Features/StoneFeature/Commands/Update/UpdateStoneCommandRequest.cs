using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Update
{
    public class UpdateStoneCommandRequest : IRequest<ResponseDto<UpdateStoneCommandResponse>>
    {
        public int Id { get; set; }
public decimal CostPrice { get; set; }
        
        public int StoneTypeId { get; set; }
        public int UnitId { get; set; }
        public int? StoneCutId { get; set; }
        public int? StoneClarityId { get; set; }
        public int? StoneScaleId { get; set; }
        public int? ColorId { get; set; }

        public int? StoneSettingId { get; set; }
    }
}
