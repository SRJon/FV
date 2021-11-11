using AutoMapper;
using back.Application.Controllers;
using back.data.entities.Enterprise;
using back.data.entities.Pedido;
using back.data.entities.Perfil;
using back.data.entities.PerfilTela;
using back.data.entities.Profile;
using back.data.entities.ProfileScreen;
using back.data.entities.Screen;
using back.data.entities.User;
using back.domain.DTO.Empresa;
using back.domain.DTO.ProfileDTO;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.DTO.ScreenDTO;
using back.domain.DTO.Usuario;

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
                //cfg.CreatePedidoItemMapper();
                cfg.CreatePerfilMapper();
                cfg.CreatePerfilTelaMapper();
                //cfg.CreateProjetosMapper();
                //cfg.CreateProjetosMapper();
                //cfg.CreatesysdiagramsMapper();
                //cfg.CreateTelaMapper();
                //cfg.CreateUserCustomizationsMapper();
                //cfg.CreateUserMapper();
                //cfg.CreateUsuarioEmpMapper();
                //cfg.CreateVersaoProjetosMapper();
                //cfg.CreateVersionDetailsMapper();
                cfg.CreateMap<Teste, testeDTO>();
            });
            return configuration;
        }
    }
}