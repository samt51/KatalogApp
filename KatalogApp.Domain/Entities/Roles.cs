using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Sistemdeki yetki gruplarını (rolleri) tutan tablo.
    /// Örn: SystemAdmin, Admin, Customer vb.
    /// </summary>
    public class Roles : BaseEntity
    {
        /// <summary>
        /// Rolün adı. (Örn: "Admin")
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Bu role sahip olan kullanıcıların listesi.
        /// </summary>
        public virtual ICollection<Users> Users { get; set; }
    }
}
