using MediatR;
namespace KatalogApp.Application.Features.UnitsFeature.Commands.Delete
{
    public class DeleteUnitsCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

