using System;

namespace KatalogApp.Domain.Commond
{
    /// <summary>
    /// Veritabanındaki tüm tabloların türediği temel (base) sınıf.
    /// Kayıt oluşturulma, güncellenme, silinme durumlarını ve kimin işlem yaptığını tutar.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Kaydın benzersiz kimlik numarası (Primary Key).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kaydın sisteme ilk eklendiği tarih ve saat.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Kaydın son güncellendiği tarih ve saat.
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// İşlemi yapan kullanıcının ID'si. (Audit/Log takibi için).
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Kaydın silinip silinmediği durumu. Soft Delete (yumuşak silme) mantığı için kullanılır. True ise veri silinmiş sayılır.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
