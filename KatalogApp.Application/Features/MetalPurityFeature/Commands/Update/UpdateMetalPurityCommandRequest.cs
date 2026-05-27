using MediatR;
namespace KatalogApp.Application.Features.MetalPurityFeature.Commands.Update
{
    public class UpdateMetalPurityCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Milyem { get; set; }
        public decimal Density { get; set; }
    }
}

