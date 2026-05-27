using MediatR;
namespace KatalogApp.Application.Features.StoneScaleFeature.Commands.Create
{
    public class CreateStoneScaleCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

