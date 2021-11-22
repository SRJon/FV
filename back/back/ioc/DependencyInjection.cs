
using back.domain.Enum;
using back.infra;
using back.infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace back.ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestruture(this IServiceCollection services, IConfiguration configuration)
        {

            services.InjectionConfig(configuration);

            // services.AddScoped<DbAppContextFVUDB_TESTE>();

            services.AddRepositoriesInject();
            return services;
        }

    }
}