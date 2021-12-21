using back.data.entities.TGFGrupoProdutoVendedor;
using back.domain.entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.TGFGrupoProduto
{
    public class TGFGRU : ITGFGRU
    {
        public int CODGRUPOPROD { get; set; }
        public string DESCRGRUPOPROD { get; set; }
        public int CODGRUPAI { get; set; }
        public string ANALITICO { get; set; }
        public short GRAU { get; set; }
        public double? LIMCURVA_B { get; set; }
        public double? LIMCURVA_C { get; set; }
        public double? COMCURVA_A { get; set; }
        public double? COMCURVA_B { get; set; }
        public double? COMCURVA_C { get; set; }
        public double? PARTICMETA { get; set; }
        public double? METAQTD { get; set; }
        public double? PERCMETACONTRIB { get; set; }
        public short? AREAOCUPUNID { get; set; }
        public double? QTDEXPOSICAO { get; set; }
        public string VALEST { get; set; }
        public byte[] IMAGEM { get; set; }
        public int? GRUPOICMS { get; set; }
        public string ATIVO { get; set; }
        public int CODNAT { get; set; }
        public int CODCENCUS { get; set; }
        public int CODPROJ { get; set; }
        public string SOLCOMPRA { get; set; }
        public double? PERCMETA { get; set; }
        public string CORFUNDO { get; set; }
        public string CORFONTE { get; set; }
        public string REGRAWMS { get; set; }
        public string PEDIRLIB { get; set; }
        public string INFTRAPEZIO { get; set; }
        public string TEMFLV { get; set; }
        public string APRPRODVDA { get; set; }
        public int? CODRFA { get; set; }
        public string AGRUPALOCVALEST { get; set; }
        public double PERCCMTNAC { get; set; }
        public double PERCCMTIMP { get; set; }
        public double? ALIQNAC { get; set; }
        public double? ALIQIMP { get; set; }
        public double PERCCMTFED { get; set; }
        public double PERCCMTEST { get; set; }
        public double PERCCMTMUN { get; set; }
        public string VISIVELAPPOS { get; set; }
        public int? CODCTACTBEFD { get; set; }
        public string FORCAEXPECONECT { get; set; }
        public int? NUVERSAO { get; set; }
        public string CONSGRUPRODCAT42 { get; set; }        
        //public virtual ICollection<TGFRGV> TGFRGV { get; set; }
    }
}
