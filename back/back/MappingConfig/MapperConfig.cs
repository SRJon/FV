using AutoMapper;
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

using back.data.entities.TGFVendedor;
using back.data.entities.TSIEmpresa;

using back.data.entities.View_AD_SALDO_PARCEIRO;

using back.data.entities.View_AD_ESTPROGPROD;
using back.data.entities.AD_FamiliaGR1;
using back.data.entities.AD_FamiliaGR2;
using back.data.entities.AD_FamiliaGR3;
using back.data.entities.TGFEXCProduto;
using back.data.entities.TGFIPImposto;
using back.data.entities.TGFProduto;
using back.data.entities.View_VGFTAB;
using back.data.entities.AD_PANTONE_Cor;
using back.data.entities.View_AD_ESTPRODCOR;
using back.data.entities.TGFTPVenda;
using back.data.entities.TCSProjeto;
using back.data.entities.TGFCABNota;
using back.data.entities.TGFGrupoProdutoVendedor;
using back.data.entities.TGFGrupoProduto;
using back.data.entities.View_AD_DEVSOLICITACAO;
using back.data.entities.TGFinanceiro;
using back.data.entities.View_AD_ITEDEVSOLICITACAO;
using back.data.entities.ViewAD_FINCOM;
using back.data.entities.AD_Estoque;

using back.data.entities.DataViews.VIEW_AD_GERAL_PV;

using back.data.entities.DataViews.VIEW_AD_PEDIDOS;
using back.data.entities.DataViews.VIEW_AD_EXTRA_PV;
using back.data.entities.DataViews.VIEW_AD_PRODUTO_PV;
using back.data.entities.UserEmp;
using back.data.entities.View_AD_TIPNEG;

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
                cfg.CreateAD_PEDIDOSDetailsMapper();
                cfg.CreateAD_GERAL_PVDetailsMapper();
                cfg.CreateAD_EXTRA_PVDetailsMapper();
                cfg.CreateAD_PRODUTO_PVDetailsMapper();
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
                cfg.CreateAD_ITEDEVSOLICITACAOMapper();
                cfg.CreateAD_FINCOMMapper();
                cfg.CreateAD_ESTCODPRODMapper();

            });
            return configuration;
        }
    }
}