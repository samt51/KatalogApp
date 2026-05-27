using MediatR;
namespace KatalogApp.Application.Features.UnitsFeature.Commands.Update
{
    public class UpdateUnitsCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

