using AutoMapper;
using back.Application.Controllers;
using back.data.entities.Enterprise;
using back.data.entities.Pedido;
using back.data.entities.PedidoItem;
using back.data.entities.Perfil;
using back.data.entities.PerfilTela;

namespace back.MappingConfig
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                //cfg.CreateAnexoContMapper();
                //cfg.CreateAnexoDevMapper();
                //cfg.CreateAnexoRepMapper();
                //cfg.CreateBookMapper();
                //cfg.CreateBookAnexoMapper();
                //cfg.CreateBProdutoMapper();
                //cfg.CreateBProdutoImgMapper();
                //cfg.CreateDiretorioMapper();
                cfg.CreateEmpresaMapper();
                //cfg.CreateInformativoMapper();
                //cfg.CreateParametroMapper();
                cfg.CreatePedidoMapper();
                cfg.CreatePedidoItemMapper();
                cfg.CreatePerfilMapper();
                cfg.CreatePerfilTelaMapper();
                //cfg.CreateProjetosMapper();                                
                cfg.CreateTelaMapper();
                //cfg.CreateUserCustomizationsMapper();
                cfg.CreateUserMapper();                
                //cfg.CreateVersaoProjetosMapper();
                //cfg.CreateVersionDetailsMapper();
                cfg.CreateMap<Teste, testeDTO>();
            });
            return configuration;
        }
    }
}