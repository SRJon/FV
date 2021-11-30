using back.data.entities.UserCustomizations;
using back.domain.entities;
using back.domain.Repositories;
using back.infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace back.ioc
{
    public static class RepositoriesInjection
    {
        public static IServiceCollection AddRepositoriesInject(this IServiceCollection services)
        {

            services.AddScoped<IAnexoContRepository, AnexoContRepository>();
            services.AddScoped<IAnexoDevRepository, AnexoDevRepository>();
            services.AddScoped<IAnexoRepRepository, AnexoRepRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBookAnexoRepository, BookAnexoRepository>();
            services.AddScoped<IBProdutoRepository, BProdutoRepository>();
            services.AddScoped<IBProdutoImgRepository, BProdutoImgRepository>();
            services.AddScoped<IDiretorioRepository, DiretorioRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IInformativoRepository, InformativoRepository>();
            services.AddScoped<IParametroRepository, ParametroRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoItemRepository, PedidoItemRepository>();
            services.AddScoped<IPerfilRepository, PerfilRepository>();
            services.AddScoped<IPerfilTelaRepository, PerfilTelaRepository>();
            services.AddScoped<IProjetosRepository, ProjetosRepository>();
            services.AddScoped<ITelaRepository, TelaRepository>();
            services.AddScoped<IUserCustomizations, UserCustomizations>();
            services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            //services.AddScoped<IUsuarioEmpRepository, UsuarioEmpRepository>();
            services.AddScoped<IVersaoProjetosRepository, VersaoProjetosRepository>();
            services.AddScoped<IVersionDetailsRepository, VersionDetailsRepository>();
            services.AddScoped<IAD_VGFRPVRepository, AD_VGFRPVRepository>();
            services.AddScoped<ITGFPARRepository, TGFPARRepository>();
            services.AddScoped<ISintegraCNPJRepository, SintegraCNPJRepository>();
            services.AddScoped<ITSIENDRepository, TSIENDRepository>();
            services.AddScoped<ITSIBAIRepository, TSIBAIRepository>();
            services.AddScoped<ITSICIDRepository, TSICIDRepository>();


            return services;
        }
    }
}