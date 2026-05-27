using MediatR;
namespace KatalogApp.Application.Features.MetalTypeFeature.Commands.Delete
{
    public class DeleteMetalTypeCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

