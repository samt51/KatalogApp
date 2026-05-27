using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Sistemdeki hem Taş Renklerini (D, E, F) hem de Maden Renklerini (Beyaz Altın, Rose vb.) ortak tutan Lookup (Referans) tablosudur.
    /// </summary>
    public class Colors : BaseEntity
    {
        /// <summary>Rengin adı (Örn: "D", "Beyaz Altın").</summary>
        public string Name { get; set; }
        
        /// <summary>Rengin varsa endüstriyel kodu (Örn: "WHT", "D").</summary>
        public string Code { get; set; }
        
        /// <summary>Bu rengin Taşa mı ("Stone") yoksa Madene mi ("Metal") ait olduğunu belirten tip.</summary>
        public string ColorType { get; set; } 
        
        /// <summary>Bu rengi kullanan taşların listesi.</summary>
        public List<Stone> Stones { get; set; }
        
        
        
    }
}
