namespace KatalogApp.Application.Features.StoneFeature.Queries.GetAll
{
    public class GetAllStoneQueryResponse
    {
        public int Id { get; set; }
public decimal CostPrice { get; set; }
        
        public int StoneTypeId { get; set; }
        public int UnitId { get; set; }
        public int? StoneCutId { get; set; }
        public int? StoneClarityId { get; set; }
        public int? ColorId { get; set; }

        public int? StoneSettingId { get; set; }
        public KatalogApp.Application.Features.StoneSettingFeature.Dtos.StoneSettingDto StoneSetting { get; set; }

        public int? StoneScaleId { get; set; }
        public KatalogApp.Application.Features.StoneScaleFeature.Dtos.StoneScaleDto StoneScale { get; set; }
    }
}
