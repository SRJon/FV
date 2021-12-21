using back.domain.DTO.TGFGrupoProduto;
using back.domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.domain.DTO.TGFRGV
{
    public class TGFRGVDTO : ITGFRGV
    {     
        public int CODGRUPOPROD { get; set; }
        public short CODVEND { get; set; }
        public DateTime? AD_DTMIGRA { get; set; }
        public virtual TGFGRUDTOList TGFGRU { get; set; }

    }
}
