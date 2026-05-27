using MediatR;
namespace KatalogApp.Application.Features.RolesFeature.Commands.Delete
{
    public class DeleteRolesCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

