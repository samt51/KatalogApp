using MediatR;
namespace KatalogApp.Application.Features.RolesFeature.Commands.Create
{
    public class CreateRolesCommandRequest : IRequest<bool>
    {
        public string Name { get; set; }
    }
}
