using MediatR;
using KatalogApp.Application.Core.Dtos;

namespace KatalogApp.Application.Features.StoneFeature.Commands.Create
{
    public class CreateStoneCommandRequest : IRequest<ResponseDto<CreateStoneCommandResponse>>
    {
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
