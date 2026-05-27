namespace KatalogApp.Application.Features.StoneFeature.Dtos
{
    public class StoneDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal CostPrice { get; set; }
        public int StoneTypeId { get; set; }
        public int UnitId { get; set; }
        public int? StoneCutId { get; set; }
        public int? StoneClarityId { get; set; }
        public int? ColorId { get; set; }
        
        public int? StoneSettingId { get; set; }
    }
}
