using back.domain.Repositories;
using back.infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace back.ioc
{
    public static class RepositoriesInjection
    {
        public static IServiceCollection AddRepositoriesInject(this IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}