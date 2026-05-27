using MediatR;
namespace KatalogApp.Application.Features.MetalPurityFeature.Commands.Create
{
    public class CreateMetalPurityCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
        public decimal Milyem { get; set; }
        public decimal Density { get; set; }
    }
}

