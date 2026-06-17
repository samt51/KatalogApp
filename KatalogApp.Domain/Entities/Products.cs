using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Sistemin merkezinde bulunan ürün/model tablosudur. Altın gramajı ve karatı gibi denormalize özet bilgileri barındırır.
    /// </summary>
    public class Products : BaseEntity
    {
        /// <summary>Ürünün benzersiz modeli / kodu (Örn: "DGF26BL00038").</summary>
        public string Code { get; set; }
        
        /// <summary>Ürünün kullanıcıya gösterilen adı.</summary>
        public string Name { get; set; }
        
        /// <summary>Ürünün varsayılan ana (vitrin) resminin adı.</summary>
        public string ImageName { get; set; }
        
        /// <summary>Ürün detayı veya açıklaması.</summary>
        public string Description { get; set; }
        
        /// <summary>Hızlı listeleme amaçlı ürünün toplam altın gramajı (Özet alan).</summary>
        public decimal Gram { get; set; }
        
        /// <summary>Ürünün genel ayarı (Örn: "14K").</summary>
        public int? MetalPurityId { get; set; }
        public virtual MetalPurity? MetalPurity { get; set; }
        
        /// <summary>Hızlı listeleme amaçlı, fireli pırlanta toplam karatı (Özet alan).</summary>
        public decimal DiamondCarat { get; set; }

        /// <summary>İşçilik maliyet çarpanı (Örn: 0.200).</summary>
        public decimal LaborMultiplier { get; set; }

        /// <summary>Cila ve rodaj gibi işlemler için sabit ürün maliyeti (Örn: 10$).</summary>
        public decimal PolishingCost { get; set; }

        /// <summary>Ürünün kaydedildiği andaki canlı has altın fiyatı (Karat değişikliklerinde tekrar hesaplanabilmesi için tutulur).</summary>
        public decimal LiveGoldPrice { get; set; }

        public decimal GoldCost { get; set; }
        public decimal LaborCost { get; set; }
        public decimal StoneCost { get; set; }
        public decimal SettingCost { get; set; }
        public decimal TotalCost { get; set; }

        /// <summary>Ürünün bağlı olduğu kategoriler.</summary>
        public virtual ICollection<Category> Categories { get; set; }

        /// <summary>Ürünün ana kaplama/maden rengi ID'si (Örn: Beyaz Altın rengi ID'si).</summary>
        public int? MetalColorId { get; set; }
        public virtual Colors? MetalColor { get; set; }

        public int? StoneColorId { get; set; }
        public virtual Colors? StoneColor { get; set; }

        public int? CurrencyId { get; set; }
        public virtual Currency? Currency { get; set; }

        /// <summary>Ürünün tüm resimlerinin listesi.</summary>
        public virtual ICollection<ProductImage> Images { get; set; }
        /// <summary>Ürünün B2B müşteri gruplarına göre fiyatlandırılmasının listesi.</summary>
        /// <summary>Ürünün üzerinde bulunan tüm taş detaylarının (Ana taş, yan taş vs) listesi.</summary>
        public virtual ICollection<ProductStone> ProductStones { get; set; }
        /// <summary>Ürünün kasa/maden özelliklerinin (Rose altın tırnak, Beyaz altın kasa gibi) listesi.</summary>
        public virtual ICollection<ProductMetal> ProductMetals { get; set; }

        public Products()
        {
            Images = new HashSet<ProductImage>();
            ProductStones = new HashSet<ProductStone>();
            ProductMetals = new HashSet<ProductMetal>();
            Categories = new HashSet<Category>();
        }
    }
}
