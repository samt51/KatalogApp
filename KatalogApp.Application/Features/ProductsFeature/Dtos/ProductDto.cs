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
        public int CategoryId { get; set; }
        public int? MetalColorId { get; set; }
        public int? StoneColorId { get; set; }
        public string CategoryName { get; set; }
        public decimal LaborMultiplier { get; set; }
        public decimal PolishingCost { get; set; }
        public decimal LiveGoldPrice { get; set; }
        public decimal CalculatedPrice { get; set; }
        public List<string> Images { get; set; }
        public List<ProductStoneDto> ProductStones { get; set; } = new List<ProductStoneDto>();
        public List<ProductMetalDto> ProductMetals { get; set; } = new List<ProductMetalDto>();
    }
}
