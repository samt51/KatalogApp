using KatalogApp.Application.Core.Dtos;
using MediatR;
using System;

namespace KatalogApp.Application.Features.UsersFeature.Commands.Create
{
    public class CreateUsersCommandRequest : IRequest<ResponseDto<CreateUsersCommandResponse>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public bool IsLocked { get; set; }

        public decimal? CustomMilyem { get; set; }
        public decimal? SalesMultiplier { get; set; }
        public System.Collections.Generic.List<Dtos.UserStonePriceDto>? CustomStonePrices { get; set; }
        public System.Collections.Generic.List<Dtos.UserPolishingCostDto>? CustomPolishingCosts { get; set; }
        public System.Collections.Generic.List<Dtos.UserSettingPriceDto>? CustomSettingPrices { get; set; }
    }
}
