using KatalogApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KatalogApp.Persistence
{
    public static class Registration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<KatalogAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    sqlServerOptions => sqlServerOptions.CommandTimeout(600))
                       .ConfigureWarnings(warnings => warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning)));

            services.AddAutoMapper(typeof(KatalogApp.Application.Registration), typeof(KatalogApp.Persistence.Registration));
            services.AddSingleton<KatalogApp.Application.Common.Abstractions.Mapper.IMapper, KatalogApp.Persistence.Common.Concrete.Mapping.Mapper>();

            services.AddScoped(typeof(KatalogApp.Application.Common.Abstractions.Repositories.IReadRepository<>), typeof(KatalogApp.Persistence.Common.Concrete.Repositories.ReadRepository<>));
            services.AddScoped(typeof(KatalogApp.Application.Common.Abstractions.Repositories.IWriteRepository<>), typeof(KatalogApp.Persistence.Common.Concrete.Repositories.WriteRepository<>));
            services.AddScoped<KatalogApp.Application.Common.Abstractions.UnitOfWorks.IUnitOfWork, KatalogApp.Persistence.Common.Concrete.UnitOfWorks.UnitOfWork>();
        }
    }
}



