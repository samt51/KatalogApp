using KatalogApp.Application.Common.Abstractions.UnitOfWorks;
using KatalogApp.Application.Interfaces.Services;
using KatalogApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KatalogApp.Infrastructure.Services
{
    public class PricingService : IPricingService
    {
        private readonly IExchangeRateService _exchangeRateService;
        private readonly IUnitOfWork _unitOfWork;

        public PricingService(IExchangeRateService exchangeRateService, IUnitOfWork unitOfWork)
        {
            _exchangeRateService = exchangeRateService;
            _unitOfWork = unitOfWork;
        }

        public async Task<decimal> CalculatePriceAsync(Products product, decimal discountRate = 0)
        {
            var res = await CalculateCustomerPricesAsync(new List<Products> { product }, null);
            return res.ContainsKey(product.Id) ? res[product.Id] : 0;
        }

        public async Task<Dictionary<int, decimal>> CalculateCustomerPricesAsync(List<Products> products, int? userId)
        {
            var result = new Dictionary<int, decimal>();
            if (products == null || !products.Any()) return result;

            decimal defaultHasPrice = await _exchangeRateService.GetHasAltinPriceAsync();
            // Fire payı çıkarıldı

            UserPricingProfile pricingProfile = null;
            List<UserStonePrice> customStones = new List<UserStonePrice>();
            List<UserPolishingCost> customPolishing = new List<UserPolishingCost>();

            if (userId.HasValue && userId.Value > 0)
            {
                var user = await _unitOfWork.GetReadRepository<Users>().GetAsync(u => u.Id == userId.Value,
                    include: i => i.Include(u => u.PricingProfile).Include(u => u.CustomStonePrices).Include(u => u.CustomPolishingCosts));
                
                if (user != null)
                {
                    pricingProfile = user.PricingProfile;
                    if (user.CustomStonePrices != null) customStones = user.CustomStonePrices.Where(s => !s.IsDeleted).ToList();
                    if (user.CustomPolishingCosts != null) customPolishing = user.CustomPolishingCosts.Where(p => !p.IsDeleted).ToList();
                }
            }

            // Cache for purities to avoid db query in loop
            var purities = await _unitOfWork.GetReadRepository<MetalPurity>().GetAllAsync();
            var purityMap = purities.ToDictionary(p => p.Id, p => p.Milyem);

            foreach (var product in products)
            {
                decimal milyem = 0.585m; // Default
                
                // Base karat milyem for gold cost
                if (product.MetalPurityId.HasValue && purityMap.ContainsKey(product.MetalPurityId.Value))
                {
                    milyem = purityMap[product.MetalPurityId.Value] > 0 ? purityMap[product.MetalPurityId.Value] : 0.585m;
                }

                // Custom Labor Milyem overrides Product's LaborMultiplier
                decimal laborMultiplier = product.LaborMultiplier;
                if (pricingProfile != null && pricingProfile.CustomMilyem.HasValue)
                {
                    laborMultiplier = pricingProfile.CustomMilyem.Value;
                }

                decimal productHasPrice = product.LiveGoldPrice > 0 ? product.LiveGoldPrice : defaultHasPrice;
                decimal goldCost = product.Gram * milyem * productHasPrice;
                decimal laborCost = product.Gram * laborMultiplier * productHasPrice;

                decimal totalStoneCost = 0;
                decimal totalSettingCost = 0;

                if (product.ProductStones != null && product.ProductStones.Any(s => !s.IsDeleted))
                {
                    foreach (var productStone in product.ProductStones.Where(s => !s.IsDeleted))
                    {
                        var stoneLot = productStone.Stone;
                        if (stoneLot == null || stoneLot.StoneSetting == null)
                        {
                            stoneLot = await _unitOfWork.GetReadRepository<Stone>()
                                .GetAsync(s => s.Id == productStone.StoneId, include: i => i.Include(x => x.StoneSetting));
                        }

                        if (stoneLot != null)
                        {
                            var customStone = customStones.FirstOrDefault(s => s.StoneId == stoneLot.Id);
                            
                            decimal stoneCostPrice = customStone != null && customStone.CustomPrice.HasValue && customStone.CustomPrice.Value > 0 
                                ? customStone.CustomPrice.Value 
                                : stoneLot.CostPrice;
                                
                            decimal stoneSettingPrice = customStone != null && customStone.CustomSettingPrice.HasValue && customStone.CustomSettingPrice.Value > 0 
                                ? customStone.CustomSettingPrice.Value 
                                : (stoneLot.StoneSetting?.SettingPrice ?? 0);

                            totalStoneCost += productStone.TotalCarat * stoneCostPrice;

                            if (stoneLot.StoneSetting?.Unit != null && !string.IsNullOrEmpty(stoneLot.StoneSetting.Unit.Name))
                            {
                                if ((stoneLot.StoneSetting.Unit.Name.ToLower().Contains("adet") == true) || (stoneLot.StoneSetting.Unit.Name.ToLower() == "piece"))
                                {
                                    totalSettingCost += productStone.Quantity * stoneSettingPrice;
                                }
                                else if ((stoneLot.StoneSetting.Unit.Name.ToLower().Contains("karat") == true) || (stoneLot.StoneSetting.Unit.Name.ToLower().Contains("ct")) || (stoneLot.StoneSetting.Unit.Name.ToLower() == "carat"))
                                {
                                    totalSettingCost += productStone.TotalCarat * stoneSettingPrice;
                                }
                            }
                        }
                    }
                }

                decimal polishingCost = product.PolishingCost;
                if (userId.HasValue)
                {
                    var customPolish = customPolishing.FirstOrDefault(p => product.Categories != null && product.Categories.Any(c => c.Id == p.CategoryId));
                    if (customPolish == null) customPolish = customPolishing.FirstOrDefault(p => p.CategoryId == null); // Fallback to all categories
                    
                    if (customPolish != null && customPolish.CustomPrice > 0)
                    {
                        polishingCost = customPolish.CustomPrice;
                    }
                }

                decimal totalCost = goldCost + laborCost + totalStoneCost + totalSettingCost + polishingCost;
                
                // Apply sales multiplier
                if (pricingProfile != null && pricingProfile.SalesMultiplier.HasValue && pricingProfile.SalesMultiplier.Value > 0)
                {
                    totalCost *= pricingProfile.SalesMultiplier.Value;
                }

                // If it's a new product or we want to save base costs, we still update the product object.
                // However, if we are returning customer pricing dynamically, we should not overwrite base costs in DB.
                // We'll just return the calculated customer price.
                if (userId == null) 
                {
                    product.GoldCost = Math.Round(goldCost, 2);
                    product.LaborCost = Math.Round(laborCost, 2);
                    product.StoneCost = Math.Round(totalStoneCost, 2);
                    product.SettingCost = Math.Round(totalSettingCost, 2);
                    product.TotalCost = Math.Round(totalCost, 2);
                }

                result[product.Id] = Math.Round(totalCost, 2);
            }

            return result;
        }
    }
}



