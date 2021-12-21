using back.domain.entities;
using System;

namespace back.data.entities.TGFGrupoProdutoVendedor
{
    public class TGFRGV : ITGFRGV
    {
     
        public int CODGRUPOPROD { get; set; }
        public short CODVEND { get; set; }
        public DateTime? AD_DTMIGRA { get; set; }       

    }
}
