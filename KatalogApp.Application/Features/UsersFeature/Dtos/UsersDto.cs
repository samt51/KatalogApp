using System;

namespace KatalogApp.Application.Features.UsersFeature.Dtos
{
    public class UsersDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleId { get; set; }
        public int? CustomerGroupId { get; set; }
        public DateTime? MembershipExpiryDate { get; set; }
        public bool IsLocked { get; set; }

        public UserPricingProfileDto? PricingProfile { get; set; }
        public System.Collections.Generic.List<UserStonePriceDto>? CustomStonePrices { get; set; }
        public System.Collections.Generic.List<UserPolishingCostDto>? CustomPolishingCosts { get; set; }
    }
}
