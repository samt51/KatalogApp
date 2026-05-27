using MediatR;
namespace KatalogApp.Application.Features.MetalTypeFeature.Commands.Update
{
    public class UpdateMetalTypeCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

