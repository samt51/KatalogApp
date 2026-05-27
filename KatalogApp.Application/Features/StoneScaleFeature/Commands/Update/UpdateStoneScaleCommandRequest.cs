using MediatR;
namespace KatalogApp.Application.Features.StoneScaleFeature.Commands.Update
{
    public class UpdateStoneScaleCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

