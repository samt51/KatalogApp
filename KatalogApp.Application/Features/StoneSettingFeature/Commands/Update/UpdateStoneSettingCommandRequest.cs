using MediatR;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Update
{
    public class UpdateStoneSettingCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public decimal SettingPrice { get; set; }
    }
}
