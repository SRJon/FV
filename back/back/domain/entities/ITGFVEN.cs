using System;

namespace back.domain.entities
{
    public interface ITGFVEN
    {
        public short CODVEND { get; set; }
        public string TIPVEND { get; set; }
        public string APELIDO { get; set; }
        public int CODPARC { get; set; }
        public int CODREG { get; set; }
        public Nullable<double> COMVENDA { get; set; }
        public Nullable<double> COMGER { get; set; }
        public Nullable<double> PARTICMETA { get; set; }
        public Nullable<short> CODEMP { get; set; }
        public short CODFORM { get; set; }
        public short CODGER { get; set; }
        public Nullable<int> CODFUNC { get; set; }
        public Nullable<short> SENHA { get; set; }
        public string ATIVO { get; set; }
        public System.DateTime DTALTER { get; set; }
        public string TIPCALC { get; set; }
        public short CODCARGAHOR { get; set; }
        public int CODCENCUSPAD { get; set; }
        public string EMAIL { get; set; }
        public Nullable<double> PERCCUSVAR { get; set; }
        public Nullable<short> DIACOM { get; set; }
        public Nullable<double> COMISSAO2 { get; set; }
        public string TIPVALOR { get; set; }
        public Nullable<short> CODUSU { get; set; }
        public Nullable<decimal> VLRHORA { get; set; }
        public double SALDODISP { get; set; }
        public double PROVACRESC { get; set; }
        public Nullable<double> DESCMAX { get; set; }
        public Nullable<double> ACRESCMAX { get; set; }
        public string GRUPORETENCAO { get; set; }
        public Nullable<int> CODFORMFLEX { get; set; }
        public string GRUPODESCVEND { get; set; }
        public double PERCTROCA { get; set; }
        public string COMCM { get; set; }
        public string RECHREXTRA { get; set; }
        public string TIPFECHCOM { get; set; }
        public string ATUACOMPRADOR { get; set; }
        public string AD_ENVIAAMOSTRA { get; set; }
        public string AD_LIBVENDCLIENTE { get; set; }
        public Nullable<int> NUVERSAO { get; set; }
        public Nullable<double> AD_12AVOS_GENIUS_LIT { get; set; }
        public Nullable<double> AD_12AVOS_GENIUS_MAI { get; set; }
        public Nullable<double> AD_12AVOS_GENIUS_ALE { get; set; }
        public string AD_CODPIPEDRIVE { get; set; }
        public Nullable<int> AD_CODGER { get; set; }
        public Nullable<double> SALDODISPCAC { get; set; }
        public Nullable<double> PROVACRESCCAC { get; set; }
        public string AD_SEGMENTO { get; set; }
        public Nullable<System.DateTime> AD_DTRESCISAO { get; set; }
        public Nullable<int> AD_MAX_MED_PRAZO { get; set; }
        public Nullable<int> AD_PRAZOPAG { get; set; }
        public string AD_COMISSAO { get; set; }
        public Nullable<System.DateTime> AD_DTMIGRA { get; set; }
        public string AD_NOMEVEND_ORIG { get; set; }
        public string AD_EMAILLITORAL { get; set; }
    }
}
