using KatalogApp.Application.Features.ProductsFeature.Dtos;
using System.Collections.Generic;

namespace KatalogApp.Application.Features.ProductsFeature.Queries.GetProductByCategoryId
{
    public class GetProductByCategoryIdQueryResponse
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public decimal Gram { get; set; }
        public int? MetalPurityId { get; set; }
        public string? MetalPurityName { get; set; }
        public decimal DiamondCarat { get; set; }
        public List<int> CategoryIds { get; set; } = new List<int>();
        public int? MetalColorId { get; set; }
        public int? StoneColorId { get; set; }
        public List<string> CategoryNames { get; set; } = new List<string>();
        public string? MetalColorName { get; set; }
        public string? StoneColorName { get; set; }
        public decimal CalculatedPrice { get; set; }
        public decimal LiveGoldPrice { get; set; }

        public List<string> Images { get; set; }
        
        public ICollection<ProductStoneDto> ProductStones { get; set; }
        public ICollection<ProductMetalDto> ProductMetals { get; set; }
    }
}
