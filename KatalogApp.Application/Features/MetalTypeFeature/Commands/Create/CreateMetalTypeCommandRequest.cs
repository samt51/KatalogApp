using MediatR;
namespace KatalogApp.Application.Features.MetalTypeFeature.Commands.Create
{
    public class CreateMetalTypeCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

