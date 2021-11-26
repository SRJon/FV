using AutoMapper;
using back.Application.Controllers;
using back.data.entities.AnexoCont;
using back.data.entities.AnexoDev;
using back.data.entities.AnexoRep;
using back.data.entities.Book;
using back.data.entities.BookAnexo;
using back.data.entities.BProduto;
using back.data.entities.BProdutoImg;
using back.data.entities.Diretorio;
using back.data.entities.Enterprise;
using back.data.entities.Informativo;
using back.data.entities.Parametro;
using back.data.entities.Request;
using back.data.entities.RequestItem;
using back.data.entities.ProfileScreen;
using back.data.entities.Profile;
using back.data.entities.Projetos;
using back.data.entities.UserCustomizations;
using back.data.entities.VersaoProjetos;
using back.data.entities.VersionDetails;
using back.data.entities.VIEW_AD_VGFRPV;
using back.data.entities.TGFParceiro;
using back.data.entities.TGFVEN;
using back.data.entities.TSIEMP;

namespace back.MappingConfig
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateAnexoContMapper();
                cfg.CreateAnexoDevMapper();
                cfg.CreateAnexoRepMapper();
                cfg.CreateBookMapper();
                cfg.CreateBookAnexoMapper();
                cfg.CreateBProdutoMapper();
                cfg.CreateBProdutoImgMapper();
                cfg.CreateDiretorioMapper();
                cfg.CreateEmpresaMapper();
                cfg.CreateInformativoMapper();
                cfg.CreateParametroMapper();
                cfg.CreatePedidoMapper();
                cfg.CreatePedidoItemMapper();
                cfg.CreatePerfilMapper();
                cfg.CreatePerfilTelaMapper();
                cfg.CreateProjetosMapper();
                cfg.CreateTelaMapper();
                cfg.CreateUserCustomizationsMapper();
                cfg.CreateUserMapper();
                cfg.CreateVersaoProjetosMapper();
                cfg.CreateVersionDetailsMapper();
                cfg.CreateAD_VGFRPVDetailsMapper();
                cfg.CreateTGFPARMapper();
                cfg.CreateTGFVENMapper();
                cfg.CreateTSIEMPMapper();
                cfg.CreateMap<Teste, testeDTO>();
            });
            return configuration;
        }
    }
}