namespace KatalogApp.Application.Features.StoneFeature.Dtos
{
    public class StoneSettingDto
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public string SettingType { get; set; } // Mapped from Unit.Name
        public decimal SettingPrice { get; set; }
    }
}
