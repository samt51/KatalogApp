using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
