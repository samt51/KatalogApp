using KatalogApp.Application.Interfaces.Services;
using KatalogApp.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace KatalogApp.Infrastructure
{
    public static class Registration
    {
        public static void AddInfrastructureRegistration(this IServiceCollection services)
        {
            services.AddHttpClient<IExchangeRateService, ExchangeRateService>();
            services.AddTransient<IPricingService, PricingService>();
        }
    }
}
