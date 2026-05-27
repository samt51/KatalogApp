using MediatR;
namespace KatalogApp.Application.Features.StoneTypeFeature.Commands.Create
{
    public class CreateStoneTypeCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

