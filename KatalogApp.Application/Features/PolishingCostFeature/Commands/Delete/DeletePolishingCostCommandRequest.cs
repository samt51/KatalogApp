
using MediatR;
namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Delete
{
    public class DeletePolishingCostCommandRequest : IRequest<DeletePolishingCostCommandResponse>
    {
        public int Id { get; set; }
    }
}
