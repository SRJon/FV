using back.domain.entities;
using System;

namespace back.data.entities.AD_Estoque
{
    public class AD_ESTCODPROD : IAD_ESTCODPROD
    {
        public int PRODUTO { get; set; }
        public int CODGRUPOPROD { get; set; }
        public string DESCRGRUPOPROD { get; set; }
        public string AD_CODANT { get; set; }
        public string CODVOL { get; set; }
        public string DESCRPROD { get; set; }
        public string COMPLDESC { get; set; }
        public double? PERCENTUAL { get; set; }
        public double? AD_LARGURATECIDO { get; set; }
        public double? AD_GRAMATURA { get; set; }
        public string NCM { get; set; }
    }
}
