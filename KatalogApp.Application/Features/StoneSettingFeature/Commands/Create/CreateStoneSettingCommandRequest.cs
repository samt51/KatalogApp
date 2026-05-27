using MediatR;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Create
{
    public class CreateStoneSettingCommandRequest : IRequest<bool>
    {
        public int UnitId { get; set; }
        public decimal SettingPrice { get; set; }
    }
}
