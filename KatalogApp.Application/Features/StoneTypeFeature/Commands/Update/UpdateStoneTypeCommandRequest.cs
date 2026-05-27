using MediatR;
namespace KatalogApp.Application.Features.StoneTypeFeature.Commands.Update
{
    public class UpdateStoneTypeCommandRequest : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

