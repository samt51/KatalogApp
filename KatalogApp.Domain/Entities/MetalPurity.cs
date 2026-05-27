using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Madenlerin ayar bilgilerini tutan Lookup (Referans) tablosudur.
    /// Örn: 8K, 14K, 18K, 22K. Yazım hatalarını önler ve standartlaştırır.
    /// </summary>
    public class MetalPurity : BaseEntity
    {
        /// <summary>Ayar adı (Örn: "14K").</summary>
        public string Name { get; set; }

        /// <summary>Ayarın milyem değeri (Örn: 14K için 0.585).</summary>
        public decimal Milyem { get; set; }

        /// <summary>Ayarın özgül ağırlığı (Yoğunluk). Örn: 14K için 13.4, 18K için 15.5</summary>
        public decimal Density { get; set; }
    }
}
