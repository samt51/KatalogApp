using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    public class UserStonePrice : BaseEntity
    {
        public int UserId { get; set; }
        public virtual Users? User { get; set; }

        public int StoneId { get; set; }
        public virtual Stone? Stone { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 4)")]        public decimal? CustomPrice { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 4)")]        public decimal? CustomSettingPrice { get; set; }
    }
}
