using back.domain.entities;
using System;

namespace back.domain.DTO.TGFVEN
{
    public class TGFVENDTOUpdateDTO : ITGFVEN
    {
        public short CODVEND { get; set; }
        public string TIPVEND { get; set; }
        public string APELIDO { get; set; }
        public int CODPARC { get; set; }
        public int CODREG { get; set; }
        public double? COMVENDA { get; set; }
        public double? COMGER { get; set; }
        public double? PARTICMETA { get; set; }
        public short? CODEMP { get; set; }
        public short CODFORM { get; set; }
        public short CODGER { get; set; }
        public int? CODFUNC { get; set; }
        public short? SENHA { get; set; }
        public string ATIVO { get; set; }
        public DateTime DTALTER { get; set; }
        public string TIPCALC { get; set; }
        public short CODCARGAHOR { get; set; }
        public int CODCENCUSPAD { get; set; }
        public string EMAIL { get; set; }
        public double? PERCCUSVAR { get; set; }
        public short? DIACOM { get; set; }
        public double? COMISSAO2 { get; set; }
        public string TIPVALOR { get; set; }
        public short? CODUSU { get; set; }
        public decimal? VLRHORA { get; set; }
        public double SALDODISP { get; set; }
        public double PROVACRESC { get; set; }
        public double? DESCMAX { get; set; }
        public double? ACRESCMAX { get; set; }
        public string GRUPORETENCAO { get; set; }
        public int? CODFORMFLEX { get; set; }
        public string GRUPODESCVEND { get; set; }
        public double PERCTROCA { get; set; }
        public string COMCM { get; set; }
        public string RECHREXTRA { get; set; }
        public string TIPFECHCOM { get; set; }
        public string ATUACOMPRADOR { get; set; }
        public string AD_ENVIAAMOSTRA { get; set; }
        public string AD_LIBVENDCLIENTE { get; set; }
        public int? NUVERSAO { get; set; }
        public double? AD_12AVOS_GENIUS_LIT { get; set; }
        public double? AD_12AVOS_GENIUS_MAI { get; set; }
        public double? AD_12AVOS_GENIUS_ALE { get; set; }
        public string AD_CODPIPEDRIVE { get; set; }
        public int? AD_CODGER { get; set; }
        public double? SALDODISPCAC { get; set; }
        public double? PROVACRESCCAC { get; set; }
        public string AD_SEGMENTO { get; set; }
        public DateTime? AD_DTRESCISAO { get; set; }
        public int? AD_MAX_MED_PRAZO { get; set; }
        public int? AD_PRAZOPAG { get; set; }
        public string AD_COMISSAO { get; set; }
        public DateTime? AD_DTMIGRA { get; set; }
        public string AD_NOMEVEND_ORIG { get; set; }
        public string AD_EMAILLITORAL { get; set; }
    }
}
