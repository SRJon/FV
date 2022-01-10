using System;

namespace back.domain.entities
{
    public interface ITGFGRU
    {
        public int CODGRUPOPROD { get; set; }
        public string DESCRGRUPOPROD { get; set; }
        public int CODGRUPAI { get; set; }
        public string ANALITICO { get; set; }
        public short GRAU { get; set; }
        public Nullable<double> LIMCURVA_B { get; set; }
        public Nullable<double> LIMCURVA_C { get; set; }
        public Nullable<double> COMCURVA_A { get; set; }
        public Nullable<double> COMCURVA_B { get; set; }
        public Nullable<double> COMCURVA_C { get; set; }
        public Nullable<double> PARTICMETA { get; set; }
        public Nullable<double> METAQTD { get; set; }
        public Nullable<double> PERCMETACONTRIB { get; set; }
        public Nullable<short> AREAOCUPUNID { get; set; }
        public Nullable<double> QTDEXPOSICAO { get; set; }
        public string VALEST { get; set; }
        public byte[] IMAGEM { get; set; }
        public Nullable<int> GRUPOICMS { get; set; }
        public string ATIVO { get; set; }
        public int CODNAT { get; set; }
        public int CODCENCUS { get; set; }
        public int CODPROJ { get; set; }
        public string SOLCOMPRA { get; set; }
        public Nullable<double> PERCMETA { get; set; }
        public string CORFUNDO { get; set; }
        public string CORFONTE { get; set; }
        public string REGRAWMS { get; set; }
        public string PEDIRLIB { get; set; }
        public string INFTRAPEZIO { get; set; }
        public string TEMFLV { get; set; }
        public string APRPRODVDA { get; set; }
        public Nullable<int> CODRFA { get; set; }
        public string AGRUPALOCVALEST { get; set; }
        public double PERCCMTNAC { get; set; }
        public double PERCCMTIMP { get; set; }
        public Nullable<double> ALIQNAC { get; set; }
        public Nullable<double> ALIQIMP { get; set; }
        public double PERCCMTFED { get; set; }
        public double PERCCMTEST { get; set; }
        public double PERCCMTMUN { get; set; }
        public string VISIVELAPPOS { get; set; }
        public Nullable<int> CODCTACTBEFD { get; set; }
        public string FORCAEXPECONECT { get; set; }
        public Nullable<int> NUVERSAO { get; set; }
        public string CONSGRUPRODCAT42 { get; set; }
    }
}
