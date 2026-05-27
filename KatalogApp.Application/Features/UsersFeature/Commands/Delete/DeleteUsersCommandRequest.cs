using MediatR;
namespace KatalogApp.Application.Features.UsersFeature.Commands.Delete
{
    public class DeleteUsersCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

