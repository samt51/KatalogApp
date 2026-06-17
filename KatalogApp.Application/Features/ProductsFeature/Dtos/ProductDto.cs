using System.Collections.Generic;

namespace KatalogApp.Application.Features.ProductsFeature.Dtos
{
    public class ProductDto
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
        public string CategoryName => CategoryNames != null ? string.Join(", ", CategoryNames) : "";
        public string Category => CategoryNames != null ? string.Join(", ", CategoryNames) : "";
        public decimal LaborMultiplier { get; set; }
        public decimal PolishingCost { get; set; }
        public decimal LiveGoldPrice { get; set; }
        public decimal CalculatedPrice { get; set; }
        public List<string> Images { get; set; }
        public List<ProductStoneDto> ProductStones { get; set; } = new List<ProductStoneDto>();
        public List<ProductMetalDto> ProductMetals { get; set; } = new List<ProductMetalDto>();
    }
}
