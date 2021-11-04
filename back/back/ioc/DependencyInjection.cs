
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
            services.AddDbContext<DbAppContextGrupoLitoral>(options =>
            options.UseSqlServer(new Settings()
            .getConnectionString(((int)ConnectionNames.GRUPOLITORAL)),
            b => b.MigrationsAssembly(typeof(DbAppContextGrupoLitoral)
            .Assembly.FullName
            )));


            services.AddScoped<DbContexts>();
            // services.AddScoped<DbAppContextFVUDB_TESTE>();

            services.AddRepositoriesInject();
            return services;
        }

    }
}