using back.infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace back.ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestruture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbAppContext>(options => options.UseSqlServer(configuration.GetConnectionString("test_grupoLitoral"), b => b.MigrationsAssembly(typeof(DbAppContext).Assembly.FullName)));


            services.AddRepositoriesInject();
            return services;
        }

    }
}