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
            services.AddScoped<IUsuarioEmpRepository, UsuarioEmpRepository>();
            services.AddScoped<IVersaoProjetosRepository, VersaoProjetosRepository>();
            services.AddScoped<IVersionDetailsRepository, VersionDetailsRepository>();
            services.AddScoped<IAD_VGFRPVRepository, AD_VGFRPVRepository>();
            services.AddScoped<ITGFPARRepository, TGFPARRepository>();
            services.AddScoped<ISintegraCNPJRepository, SintegraCNPJRepository>();
            services.AddScoped<ITSIENDRepository, TSIENDRepository>();
            services.AddScoped<ITSIBAIRepository, TSIBAIRepository>();
            services.AddScoped<ITSICIDRepository, TSICIDRepository>();
            services.AddScoped<ITGFCTTRepository, TGFCTTRepository>();
            services.AddScoped<ITGFVENRepository, TGFVENRepository>();
            services.AddScoped<ITSIEMPRepository, TSIEMPRepository>();
            services.AddScoped<IAD_TIPNEGRepository, AD_TIPNEGRepository>();
            services.AddScoped<IAD_SALDO_PARCEIRORepository, AD_SALDO_PARCEIRORepository>();
            services.AddScoped<IAD_ESTPROGPRODRepository, AD_ESTPROGPRODRepository>();
            services.AddScoped<IAD_FAMGR1Repository, AD_FAMGR1Repository>();
            services.AddScoped<IAD_FAMGR2Repository, AD_FAMGR2Repository>();
            services.AddScoped<IAD_FAMGR3Repository, AD_FAMGR3Repository>();
            services.AddScoped<ITGFEXCRepository, TGFEXCRepository>();
            services.AddScoped<ITGFIPIRepository, TGFIPIRepository>();
            services.AddScoped<ITGFPRORepository, TGFPRORepository>();
            services.AddScoped<IVGFTABRepository, VGFTABRepository>();
            services.AddScoped<IAD_PANTONERepository, AD_PANTONERepository>();
            services.AddScoped<IAD_ESTPRODCORRepository, AD_ESTPRODCORRepository>();
            services.AddScoped<ITGFTPVRepository, TGFTPVRepository>();
            services.AddScoped<ITCSPRJRepository, TCSPRJRepository>();
            services.AddScoped<ITGFCABRepository, TGFCABRepository>();
            services.AddScoped<ITGFRGVRepository, TGFRGVRepository>();
            services.AddScoped<ITGFGRURepository, TGFGRURepository>();
            services.AddScoped<IAD_DEVSOLICITACAORepository, AD_DEVSOLICITACAORepository>();
            services.AddScoped<ITGFFINRepository, TGFFINRepository>();
            services.AddScoped<IAD_ITEDEVSOLICITACAORepository, AD_ITEDEVSOLICITACAORepository>();
            services.AddScoped<IAD_FINCOMRepository, AD_FINCOMRepository>();
            services.AddScoped<IAD_ESTCODPRODRepository, AD_ESTCODPRODRepository>();

            return services;
        }
    }
}