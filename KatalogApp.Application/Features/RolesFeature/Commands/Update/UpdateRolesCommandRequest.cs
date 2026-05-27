using MediatR;
namespace KatalogApp.Application.Features.RolesFeature.Commands.Update
{
    public class UpdateRolesCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
