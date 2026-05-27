using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Pırlanta ve değerli taşların Kesim (Cut) şekillerini tutan Lookup (Referans) tablosudur.
    /// Örn: Round, Baguette, Princess vb. Ürün filtrelemelerinde kritik öneme sahiptir.
    /// </summary>
    public class StoneCut : BaseEntity
    {
        /// <summary>Kesim şeklinin adı (Örn: "Round").</summary>
        public string Name { get; set; }
    }
}
