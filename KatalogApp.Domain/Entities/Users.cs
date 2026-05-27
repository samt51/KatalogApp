using KatalogApp.Domain.Commond;
using System;

namespace KatalogApp.Domain.Entities
{
    /// <summary>
    /// Sisteme giriş yapacak olan personellerin ve B2B müşterilerin bilgilerini tutan tablo.
    /// </summary>
    public class Users : BaseEntity
    {
        /// <summary>Kullanıcının sisteme giriş yapacağı e-posta adresi.</summary>
        public string Email { get; set; }
        
        /// <summary>Kullanıcının giriş şifresi (Şifrelenmiş/Hashed olarak tutulur).</summary>
        public string Password { get; set; }
        
        /// <summary>Kullanıcının iletişim numarası.</summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>Kullanıcının gerçek adı.</summary>
        public string FirstName { get; set; }
        
        /// <summary>Kullanıcının soyadı.</summary>
        public string LastName { get; set; }
        
        /// <summary>B2B müşterisi ise çalışmış olduğu firmanın adı.</summary>
        public string CompanyName { get; set; }
        
        /// <summary>Kullanıcının/Müşterinin adresi.</summary>
        public string Address { get; set; }

        /// <summary>B2B müşterisinin sisteme erişim hakkının biteceği tarih.</summary>
        public DateTime SubscriptionEndDate { get; set; }
        
        /// <summary>Kullanıcının hesabı kilitli mi? (Süresi bittiyse veya manuel engellendiyse True olur).</summary>
        public bool IsLocked { get; set; }

        /// <summary>Kullanıcının yetki rolü ID'si (Admin mi, Müşteri mi?).</summary>
        public int RoleId { get; set; }
        
        /// <summary>Kullanıcının yetki rolü ilişkisi.</summary>
        public virtual Roles? Roles { get; set; }
        
        public virtual UserPricingProfile? PricingProfile { get; set; }
        public virtual System.Collections.Generic.ICollection<UserStonePrice>? CustomStonePrices { get; set; }
        public virtual System.Collections.Generic.ICollection<UserPolishingCost>? CustomPolishingCosts { get; set; }
        public virtual System.Collections.Generic.ICollection<UserSettingPrice>? UserSettingPrices { get; set; }
    }
}
