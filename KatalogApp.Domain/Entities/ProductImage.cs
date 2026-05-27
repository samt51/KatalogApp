using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ürünlerin varyasyon ve detay resimlerini çoklu olarak tutan tablo.
    /// </summary>
    public class ProductImage : BaseEntity
    {
        /// <summary>Resmin ait olduğu ürünün ID'si.</summary>
        public int ProductId { get; set; }
        /// <summary>Resmin ait olduğu ürün ilişkisi.</summary>
        public virtual Products Product { get; set; }

        /// <summary>Sunucudaki resim dosyasının adı (Örn: "DGF26BL00038-2.jpg").</summary>
        public string ImageName { get; set; }
        
        /// <summary>Resmin ekrandaki gösterim sırası (1 = Ana resim, 2, 3...)</summary>
        public int SortOrder { get; set; }
    }
}
