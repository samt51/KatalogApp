using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ürün ile Taþlar arasýndaki (Ana taþ, Yan taþlar vb.) çoklu (N-N) iliþkiyi yöneten ara tablo.
    /// Örn: Bir yüzükte hem yuvarlak kesim pýrlanta hem de baget taþ olabilir.
    /// </summary>
    public class ProductStone : BaseEntity
    {
        /// <summary>Taþýn eklendiði ürünün ID'si.</summary>
        public int ProductId { get; set; }
        /// <summary>Ürün iliþkisi.</summary>
        public virtual Products? Product { get; set; }

        /// <summary>Ürüne eklenen taþýn ID'si (Lookup tablosundan seçilen taþ referansý).</summary>
        public int StoneId { get; set; }
        /// <summary>Taþ iliþkisi.</summary>
        public virtual Stone? Stone { get; set; }

        /// <summary>Ürüne bu taþtan kaç adet eklendiði.</summary>
        public decimal Quantity { get; set; }
        
        /// <summary>Eklenen bu taþýn adet baþýna karatý.</summary>
        public decimal Carat { get; set; }
        
        /// <summary>Eklenen taþlarýn toplam karatý (Source of Truth).</summary>
                public decimal TotalCarat { get; set; }

        public int? ClarityId { get; set; }
        public virtual StoneClarity? Clarity { get; set; }
        public int? ColorId { get; set; }
        public virtual Colors? Color { get; set; }
    }
}


