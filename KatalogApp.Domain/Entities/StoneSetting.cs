using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    public class StoneSetting : BaseEntity
    {
        public int UnitId { get; set; }
        public virtual Units Unit { get; set; }
        public decimal SettingPrice { get; set; }

        public virtual ICollection<Stone> Stones { get; set; }
    }
}
