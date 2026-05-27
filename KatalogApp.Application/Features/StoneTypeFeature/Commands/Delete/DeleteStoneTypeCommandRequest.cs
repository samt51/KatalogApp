using MediatR;
namespace KatalogApp.Application.Features.StoneTypeFeature.Commands.Delete
{
    public class DeleteStoneTypeCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

