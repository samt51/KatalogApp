namespace KatalogApp.Application.Features.ProductsFeature.Dtos
{
    public class ProductStoneDto
    {
        public int Id { get; set; }
        public int StoneId { get; set; }
        public string StoneName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Carat { get; set; }
        public decimal TotalCarat { get; set; }
        public int? ClarityId { get; set; }
        public string? ClarityName { get; set; }
        public int? ColorId { get; set; }
        public string? ColorName { get; set; }
    }
}


