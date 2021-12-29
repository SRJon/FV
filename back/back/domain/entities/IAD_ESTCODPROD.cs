using System;

namespace back.domain.entities
{
    /*
     * VIEW CRIADA PARA O FORÇA DE VENDAS : ESTOQUE
     */
    public interface IAD_ESTCODPROD
    {
        public int PRODUTO { get; set; }
        public int CODGRUPOPROD { get; set; }
        public String DESCRGRUPOPROD { get; set; }
        public String AD_CODANT { get; set; }
        public String CODVOL { get; set; }
        public String DESCRPROD { get; set; }
        public String COMPLDESC { get; set; }       
        public Nullable<Double> AD_LARGURATECIDO { get; set; }        
        public Nullable<Double> AD_GRAMATURA { get; set; }
        public String NCM { get; set; }
        public Nullable<Double> PERCENTUAL { get; set; }

    }
}
