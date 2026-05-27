using MediatR;
using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Common.Abstractions.Mapper;
using KatalogApp.Application.Core.Dtos;
using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace KatalogApp.Application.Features.UsersFeature.Commands.Update
{
    public class UpdateUsersCommandHandler : IRequestHandler<UpdateUsersCommandRequest, ResponseDto<UpdateUsersCommandResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUsersCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ResponseDto<UpdateUsersCommandResponse>> Handle(UpdateUsersCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.GetReadRepository<Users>().GetAsync(u => u.Id == request.Id, 
                include: i => Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.Include(i, u => u.PricingProfile).Include(u => u.CustomStonePrices).Include(u => u.CustomPolishingCosts).Include(u => u.UserSettingPrices), enableTracking: true);

            entity.FirstName = request.FirstName;
            entity.LastName = request.LastName;
            entity.CompanyName = request.CompanyName;
            entity.Address = request.Address;
            entity.Email = request.Email;
            entity.PhoneNumber = request.PhoneNumber;
            entity.RoleId = request.RoleId;
            entity.IsLocked = request.IsLocked;

                if (!string.IsNullOrEmpty(request.Password))
                {
                    entity.Password = KatalogApp.Application.Helpers.PasswordHash.HashPassword(request.Password);
                }
            if (request.SubscriptionEndDate.HasValue)
                entity.SubscriptionEndDate = request.SubscriptionEndDate.Value;


            // Update Pricing Profile
            if (request.CustomMilyem.HasValue || request.SalesMultiplier.HasValue) {
                if (entity.PricingProfile == null) entity.PricingProfile = new UserPricingProfile { UserId = entity.Id };
                entity.PricingProfile.CustomMilyem = request.CustomMilyem;
                entity.PricingProfile.SalesMultiplier = request.SalesMultiplier;
            } else {
                if (entity.PricingProfile != null) {
                    await _unitOfWork.GetWriteRepository<UserPricingProfile>().HardDeleteRangeAsync(new List<UserPricingProfile> { entity.PricingProfile });
                    entity.PricingProfile = null;
                }
            }

            // Update Stone Prices
            if (entity.CustomStonePrices != null && entity.CustomStonePrices.Any()) {
                await _unitOfWork.GetWriteRepository<UserStonePrice>().HardDeleteRangeAsync(entity.CustomStonePrices.ToList());
            }
            entity.CustomStonePrices = new List<UserStonePrice>();
            if (request.CustomStonePrices != null && request.CustomStonePrices.Any()) {
                entity.CustomStonePrices = request.CustomStonePrices.Select(x => new UserStonePrice { UserId = entity.Id, StoneId = x.StoneId, CustomPrice = x.CustomPrice, CustomSettingPrice = x.CustomSettingPrice }).ToList();
            }

            // Update Polishing Costs
            if (entity.CustomPolishingCosts != null && entity.CustomPolishingCosts.Any()) {
                await _unitOfWork.GetWriteRepository<UserPolishingCost>().HardDeleteRangeAsync(entity.CustomPolishingCosts.ToList());
            }
            entity.CustomPolishingCosts = new List<UserPolishingCost>();
            if (request.CustomPolishingCosts != null && request.CustomPolishingCosts.Any()) {
                entity.CustomPolishingCosts = request.CustomPolishingCosts.Select(x => new UserPolishingCost { UserId = entity.Id, CategoryId = x.CategoryId, CustomPrice = x.CustomPrice }).ToList();
            }

            
            // Update Setting Prices
            if (entity.UserSettingPrices != null && entity.UserSettingPrices.Any()) {
                await _unitOfWork.GetWriteRepository<KatalogApp.Domain.Entities.UserSettingPrice>().HardDeleteRangeAsync(entity.UserSettingPrices.ToList());
            }
            entity.UserSettingPrices = new List<KatalogApp.Domain.Entities.UserSettingPrice>();
            if (request.CustomSettingPrices != null && request.CustomSettingPrices.Any()) {
                entity.UserSettingPrices = request.CustomSettingPrices.Select(x => new KatalogApp.Domain.Entities.UserSettingPrice { UserId = entity.Id, StoneSettingId = x.StoneSettingId, CustomPrice = x.CustomPrice }).ToList();
            }

            await _unitOfWork.GetWriteRepository<Users>().UpdateAsync(entity, cancellationToken);
            await _unitOfWork.SaveAsync(cancellationToken);
            return new ResponseDto<UpdateUsersCommandResponse>().Success();
        }
    }
}

