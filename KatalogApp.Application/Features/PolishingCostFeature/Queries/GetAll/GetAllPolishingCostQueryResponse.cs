
using KatalogApp.Application.Features.PolishingCostFeature.Dtos;
using System.Collections.Generic;
namespace KatalogApp.Application.Features.PolishingCostFeature.Queries.GetAll
{
    public class GetAllPolishingCostQueryResponse
    {
        public List<PolishingCostDto> PolishingCosts { get; set; }
    }
}
