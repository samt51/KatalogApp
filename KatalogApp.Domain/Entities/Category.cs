using KatalogApp.Domain.Commond;
using System.Collections.Generic;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ürünlerin listelendiği ana ve alt kategorileri tutar.
    /// </summary>
    public class Category : BaseEntity
    {
        /// <summary>Kategorinin adı (Örn: "Pırlanta", "Yüzük").</summary>
        public string Name { get; set; }
        

        /// <summary>Eğer alt kategori ise, bağlı olduğu ana kategorinin ID'si (Örn: Pırlanta->Tektaş durumunda Tektaş'ın ParentId'si Pırlanta'nın Id'sidir. 0 ise Ana Kategoridir).</summary>
        public int? ParentId { get; set; }

        /// <summary>Sıralama indeksi.</summary>
        public int OrderIndex { get; set; }

        /// <summary>Bu kategoriye ait ürünlerin listesi.</summary>
        public virtual ICollection<Products> Products { get; set; }
    }
}
