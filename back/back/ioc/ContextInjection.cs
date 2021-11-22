
using back.domain.Enum;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace back.ioc
{
    public static class ContextInjection
    {
        public static IServiceCollection InjectionConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = new Settings(configuration);
            services.AddDbContext<DbAppContextFVUDB_TESTE>(options =>
            options.UseSqlServer(settings
            .getConnectionString(((int)ConnectionNames.SANKHYA_FVU_TESTE)),
            b => b.MigrationsAssembly(typeof(DbAppContextFVUDB_TESTE)
            .Assembly.FullName
            )));


            services.AddDbContext<DbAppContextSankhya>(options =>
            options.UseSqlServer(settings
            .getConnectionString(((int)ConnectionNames.SANKHYA_TESTE)),
            b => b.MigrationsAssembly(typeof(DbAppContextSankhya)
            .Assembly.FullName
            )));


            services.AddScoped<DbContexts>();


            return services;
        }

    }
}
