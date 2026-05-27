using MediatR;
namespace KatalogApp.Application.Features.StoneCutFeature.Commands.Delete
{
    public class DeleteStoneCutCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

