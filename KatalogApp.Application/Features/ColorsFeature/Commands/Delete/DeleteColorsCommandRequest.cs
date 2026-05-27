using MediatR;
namespace KatalogApp.Application.Features.ColorsFeature.Commands.Delete
{
    public class DeleteColorsCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

