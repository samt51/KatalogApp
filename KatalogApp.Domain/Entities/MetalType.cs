using KatalogApp.Domain.Commond;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Ürünlerde kullanılan maden tiplerini tutan Lookup (Referans) tablosudur.
    /// Örn: Altın, Gümüş, Platin vb. Veri kirliliğini önler.
    /// </summary>
    public class MetalType : BaseEntity
    {
        /// <summary>Maden türünün adı (Örn: "Altın").</summary>
        public string Name { get; set; }
    }
}
