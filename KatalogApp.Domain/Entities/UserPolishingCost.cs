using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    public class UserPolishingCost : BaseEntity
    {
        public int UserId { get; set; }
        public virtual Users? User { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 4)")]        public decimal CustomPrice { get; set; }
    }
}
