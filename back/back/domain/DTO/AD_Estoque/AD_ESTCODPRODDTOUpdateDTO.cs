using back.domain.entities;

namespace back.domain.DTO.AD_Estoque
{
    public class AD_ESTCODPRODDTOUpdateDTO : IAD_ESTCODPROD
    {
        public int PRODUTO { get; set; }
        public int CODGRUPOPROD { get; set; }
        public string AD_CODANT { get; set; }
        public string CODVOL { get; set; }
        public string DESCRPROD { get; set; }
        public string COMPLDESC { get; set; }
        public double? PERCENTUAL { get; set; }
        public double? AD_LARGURATECIDO { get; set; }
        public double? AD_GRAMATURA { get; set; }
        public string NCM { get; set; }
        public double? AD_RENDIMENTOTECIDO { get; set; }
        public string AD_BRIEFING { get; set; }
    }
}
