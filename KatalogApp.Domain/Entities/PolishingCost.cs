using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    public class PolishingCost : BaseEntity
    {
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
        public decimal CostPrice { get; set; }
    }
}
