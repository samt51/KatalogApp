using MediatR;
namespace KatalogApp.Application.Features.MetalPurityFeature.Commands.Delete
{
    public class DeleteMetalPurityCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

