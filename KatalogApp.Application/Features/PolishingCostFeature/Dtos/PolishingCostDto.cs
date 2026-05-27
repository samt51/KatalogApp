
using System;
namespace KatalogApp.Application.Features.PolishingCostFeature.Dtos
{
    public class PolishingCostDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal CostPrice { get; set; }
    }
}
