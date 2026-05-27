using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ürünün kasa ve maden yapısının detaylarını barındıran tablo.
    /// Ürünlerin gövdesi, tırnağı veya genel yapısı için farklı altın ayar/renk kombinasyonlarına izin verir.
    /// </summary>
    public class ProductMetal : BaseEntity
    {
        /// <summary>Maden özelliğinin bağlandığı ürünün ID'si.</summary>
        public int ProductId { get; set; }
        /// <summary>Ürün ilişkisi.</summary>
        public virtual Products Product { get; set; }

        /// <summary>Maden tipi referansı (Altın, Gümüş, Platin vb.).</summary>
        public int MetalTypeId { get; set; }
        /// <summary>Maden tipi ilişkisi.</summary>
        public virtual MetalType? MetalType { get; set; }

        /// <summary>Maden ayarı referansı (14K, 18K vb.).</summary>
        public int MetalPurityId { get; set; }
        /// <summary>Maden ayarı ilişkisi.</summary>
        public virtual MetalPurity? MetalPurity { get; set; }

        /// <summary>Madenin rengi (Beyaz, Rose vb.).</summary>
        public int? ColorId { get; set; }
        /// <summary>Renk ilişkisi.</summary>
        public virtual Colors? Colors { get; set; }

        /// <summary>Bu metalin üründeki net ağırlığı (Gram).</summary>
        public decimal Weight { get; set; }
    }
}
