using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    public class StoneScale : BaseEntity
    {
        public string Name { get; set; } // e.g. "-2 Yuvarlak", "-6.5 Yuvarlak"

        public virtual ICollection<Stone> Stones { get; set; }
    }
}