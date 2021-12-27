using AutoMapper;
using back.Application.Controllers;
using back.data.entities.AnexoCont;
using back.data.entities.AnexoDev;
using back.data.entities.AnexoRep;
using back.data.entities.BookAmostra;
using back.data.entities.BookAnexoAmostra;
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
using back.data.entities.TSIEndereco;
using back.data.entities.TSIBairro;
using back.data.entities.TSICidade;
using back.data.entities.TGFContato;

using back.data.entities.TGFVEN;
using back.data.entities.TSIEmpresa;
using back.data.entities.UserEmp;
using back.data.entities.AD_TIPNEG;
using back.data.entities.View_AD_SALDO_PARCEIRO;
using back.data.entities.AD_ESTPROGPROD;
using back.data.entities.AD_FAMGR1;
using back.data.entities.AD_FAMGR2;
using back.data.entities.AD_FAMGR3;
using back.data.entities.TGFEXC;
using back.data.entities.TGFIPI;
using back.data.entities.TGFProduto;
using back.data.entities.VGFTAB;
using back.data.entities.AD_PANTONE;
using back.data.entities.AD_ESTPRODCOR;
using back.data.entities.TGFTPVenda;
using back.data.entities.TCSProjeto;
using back.data.entities.TGFCABNota;
using back.data.entities.TGFGrupoProdutoVendedor;
using back.data.entities.TGFGrupoProduto;
using back.data.entities.View_AD_DEVSOLICITACAO;
using back.data.entities.TGFinanceiro;

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
                cfg.CreateUsuarioEmpMapper();
                cfg.CreateVersaoProjetosMapper();
                cfg.CreateVersionDetailsMapper();
                cfg.CreateAD_VGFRPVDetailsMapper();
                cfg.CreateTGFPARMapper();
                cfg.CreateTSIENDMapper();
                cfg.CreateTSIBAIMapper();
                cfg.CreateTSICIDMapper();
                cfg.CreateTGFCTTMapper();
                cfg.CreateTGFVENMapper();
                cfg.CreateTSIEMPMapper();
                cfg.CreateAD_TIPNEGMapper();
                cfg.CreateTGFCABMapper();
                cfg.CreateTGFFINMapper();

                cfg.CreateAD_SALDO_PARCEIROMapper();
                //cfg.CreateMap<Teste, testeDTO>();

                cfg.CreateAD_ESTPROGPRODMapper();
                cfg.CreateAD_FAMGR1Mapper();
                cfg.CreateAD_FAMGR2Mapper();
                cfg.CreateAD_FAMGR3Mapper();
                cfg.CreateTGFEXCMapper();
                cfg.CreateTGFIPIMapper();
                cfg.CreateTGFPROMapper();
                cfg.CreateVGFTABMapper();
                cfg.CreateAD_PANTONEMapper();
                cfg.CreateAD_ESTPRODCORMapper();
                cfg.CreateTGFTPVMapper();
                cfg.CreateTCSPRJMapper();
                cfg.CreateTGFRGVMapper();
                cfg.CreateTGFGRUMapper();
                cfg.CreateAD_DEVSOLICITACAOMapper();

            });
            return configuration;
        }
    }
}