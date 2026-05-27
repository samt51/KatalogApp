using KatalogApp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KatalogApp.Application.Interfaces.Services
{
    public interface IPricingService
    {
        Task<decimal> CalculatePriceAsync(Products product, decimal discountRate = 0);
        Task<Dictionary<int, decimal>> CalculateCustomerPricesAsync(List<Products> products, int? userId);
    }
}
