using MediatR;
namespace KatalogApp.Application.Features.ColorsFeature.Commands.Create
{
    public class CreateColorsCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

