namespace KatalogApp.Application.Features.ProductsFeature.Dtos
{
    public class ProductMetalDto
    {
        public int Id { get; set; }
        public int MetalTypeId { get; set; }
        public string MetalTypeName { get; set; }
        public int? MetalPurityId { get; set; }
        public string? MetalPurityName { get; set; }
        public decimal Gram { get; set; }
    }
}
