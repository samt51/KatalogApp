using MediatR;

namespace KatalogApp.Application.Features.StoneSettingFeature.Commands.Delete
{
    public class DeleteStoneSettingCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
