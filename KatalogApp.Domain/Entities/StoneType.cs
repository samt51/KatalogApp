using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Kullanılan değerli taşların türlerini/cinslerini tutan Lookup (Referans) tablosudur.
    /// Örn: Pırlanta, Safir, Zümrüt, Yakut vb.
    /// </summary>
    public class StoneType : BaseEntity
    {
        /// <summary>Taş cinsinin adı (Örn: "Pırlanta").</summary>
        public string Name { get; set; }
    }
}
