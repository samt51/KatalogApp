using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    public class UserPricingProfile : BaseEntity
    {
        public int UserId { get; set; }
        public virtual Users? User { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 4)")]        public decimal? CustomMilyem { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 4)")]        public decimal? SalesMultiplier { get; set; }
    }
}
