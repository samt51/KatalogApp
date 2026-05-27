using MediatR;
namespace KatalogApp.Application.Features.StoneScaleFeature.Commands.Delete
{
    public class DeleteStoneScaleCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

