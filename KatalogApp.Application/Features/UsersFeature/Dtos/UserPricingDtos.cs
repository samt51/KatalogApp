namespace KatalogApp.Application.Features.UsersFeature.Dtos
{
    public class UserStonePriceDto
    {
        public int StoneId { get; set; }
        public decimal? CustomPrice { get; set; }
        public decimal? CustomSettingPrice { get; set; }
    }

    public class UserPolishingCostDto
    {
        public int? CategoryId { get; set; }
        public decimal CustomPrice { get; set; }
    }
    
    public class UserPricingProfileDto
    {
        public decimal? CustomMilyem { get; set; }
        public decimal? SalesMultiplier { get; set; }
    }
}
