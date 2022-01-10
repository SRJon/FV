using back.data.entities.TGFGrupoProduto;
using back.domain.entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.TGFGrupoProdutoVendedor
{
    public class TGFRGV : ITGFRGV
    {        
        public int CODGRUPOPROD { get; set; }
        public short CODVEND { get; set; }
        public DateTime? AD_DTMIGRA { get; set; }

        public virtual TGFGRU TGFGRU { get; set; }


    }
}
