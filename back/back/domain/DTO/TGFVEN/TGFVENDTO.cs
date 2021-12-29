using back.domain.entities;
using System;

namespace back.domain.DTO.TGFVEN
{
    public class TGFVENDTO : ITGFVEN
    {
        public short codvend { get; set; }
        public string tipvend { get; set; }
        public string apelido { get; set; }
        public int codparc { get; set; }
        public int codreg { get; set; }
        public double? comvenda { get; set; }
        public double? comger { get; set; }
        public double? particmeta { get; set; }
        public short? codemp { get; set; }
        public short codform { get; set; }
        public short codger { get; set; }
        public int? codfunc { get; set; }
        public short? senha { get; set; }
        public string ativo { get; set; }
        public DateTime dtalter { get; set; }
        public string tipcalc { get; set; }
        public short codcargahor { get; set; }
        public int codcencuspad { get; set; }
        public string email { get; set; }
        public double? perccusvar { get; set; }
        public short? diacom { get; set; }
        public double? comissao2 { get; set; }
        public string tipvalor { get; set; }
        public short? codusu { get; set; }
        public decimal? vlrhora { get; set; }
        public double saldodisp { get; set; }
        public double provacresc { get; set; }
        public double? descmax { get; set; }
        public double? acrescmax { get; set; }
        public string gruporetencao { get; set; }
        public int? codformflex { get; set; }
        public string grupodescvend { get; set; }
        public double perctroca { get; set; }
        public string comcm { get; set; }
        public string rechrextra { get; set; }
        public string tipfechcom { get; set; }
        public string atuacomprador { get; set; }
        public string ad_enviaamostra { get; set; }
        public string ad_libvendcliente { get; set; }
        public int? nuversao { get; set; }
        public double? ad_12avos_genius_lit { get; set; }
        public double? ad_12avos_genius_mai { get; set; }
        public double? ad_12avos_genius_ale { get; set; }
        public string ad_codpipedrive { get; set; }
        public int? ad_codger { get; set; }
        public double? saldodispcac { get; set; }
        public double? provacresccac { get; set; }
        public string ad_segmento { get; set; }
        public DateTime? ad_dtrescisao { get; set; }
        public int? ad_max_med_prazo { get; set; }
        public int? ad_prazopag { get; set; }
        public string ad_comissao { get; set; }
        public DateTime? ad_dtmigra { get; set; }
        public string ad_nomevend_orig { get; set; }
        public string ad_emaillitoral { get; set; }
    }
}
