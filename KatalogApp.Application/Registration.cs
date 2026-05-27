using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace KatalogApp.Application
{
    public static class Registration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}


