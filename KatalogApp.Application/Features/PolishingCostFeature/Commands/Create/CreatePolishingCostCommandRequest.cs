
using MediatR;
namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Create
{
    public class CreatePolishingCostCommandRequest : IRequest<CreatePolishingCostCommandResponse>
    {
        public int CategoryId { get; set; }
        public decimal CostPrice { get; set; }
    }
}
