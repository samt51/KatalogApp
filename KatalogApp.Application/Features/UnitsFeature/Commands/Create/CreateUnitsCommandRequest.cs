using MediatR;
namespace KatalogApp.Application.Features.UnitsFeature.Commands.Create
{
    public class CreateUnitsCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}

