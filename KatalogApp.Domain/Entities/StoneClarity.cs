using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Pırlanta ve değerli taşların Berraklık (Clarity) derecelerini tutan Lookup (Referans) tablosudur.
    /// Örn: FL, VVS1, VS2 vb. Uluslararası standartları sağlamak içindir.
    /// </summary>
    public class StoneClarity : BaseEntity
    {
        /// <summary>Berraklık derecesinin adı (Örn: "VVS1").</summary>
        public string Name { get; set; }
    }
}
