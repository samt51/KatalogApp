
using MediatR;
namespace KatalogApp.Application.Features.PolishingCostFeature.Commands.Update
{
    public class UpdatePolishingCostCommandRequest : IRequest<UpdatePolishingCostCommandResponse>
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public decimal CostPrice { get; set; }
    }
}
