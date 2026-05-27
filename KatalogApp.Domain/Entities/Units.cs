using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ağırlık ve adet ölçüm birimlerini tutan Lookup (Referans) tablosudur.
    /// Örn: Adet, Ct, Gram.
    /// </summary>
    public class Units : BaseEntity
    {
        /// <summary>Birim adı (Örn: "Gram", "Adet").</summary>
        public string Name { get; set; } 
        
        /// <summary>Birimin kısa kodu (Örn: "Gr", "Ct").</summary>
        public string Code { get; set; }
        
        /// <summary>Bu birimi kullanan taşların (Stone tablosu) listesi.</summary>
        public List<Stone> Stones { get; set; }

        public virtual ICollection<StoneSetting> StoneSettings { get; set; }
    }
}
