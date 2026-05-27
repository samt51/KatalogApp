using MediatR;
namespace KatalogApp.Application.Features.StoneClarityFeature.Commands.Delete
{
    public class DeleteStoneClarityCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

