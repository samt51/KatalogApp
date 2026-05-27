using KatalogApp.Domain.Commond;
using System.ComponentModel.DataAnnotations.Schema;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Kullanıcıların sistemdeki hareketlerini (log) tutan tablo.
    /// Kim hangi ürüne baktı, ne aradı gibi işlemleri loglamak için kullanılır.
    /// </summary>
    public class UserActionLog : BaseEntity
    {
        /// <summary>İşlemi yapan kullanıcının ID'si.</summary>
        public int UserId { get; set; }
        
        /// <summary>Yapılan eylemin türü (Örn: "Login", "ViewProduct", "Search", "Logout").</summary>
        public string ActionType { get; set; }

        /// <summary>Eğer işlem spesifik bir ürün üzerinde yapılmışsa ilgili ürünün ID'si.</summary>
        public int? ProductId { get; set; }

        /// <summary>İşlemle ilgili detaylı bilgi veya JSON veri (Örn: Hangi filtrelerle arama yaptı).</summary>
        public string? Details { get; set; }

        /// <summary>Kullanıcının işlem yaptığı IP Adresi.</summary>
        public string? IpAddress { get; set; }

        /// <summary>İşlemin yapıldığı cihaz veya tarayıcı bilgisi.</summary>
        public string? UserAgent { get; set; }

        [ForeignKey("UserId")]
        public virtual Users User { get; set; }

        [ForeignKey("ProductId")]
        public virtual Products Product { get; set; }
    }
}
