using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.View_AD_PEDDTO
{
    public class AD_PEDPedidoDTO
    {
        public int adPedidoid { get; set; }
        public int pedNunota { get; set; }
        public string nomefantasia { get; set; }
        public string nomeparc { get; set; }
        public string estoqueAbreviado { get; set; }
        public int codproj { get; set; }
        public int pedNumnota { get; set; }
        public int? notaNumnota { get; set; }
        public double vlrpedido { get; set; }
        public string cancelado { get; set; }
        public DateTime dtmov { get; set; }
        public string adStatus { get; set; }
        public string statusPed { get; set; }//esse é o utilizado
        public int? notaNunota { get; set; }
        public string motvcanc { get; set; }
        public int codparc { get; set; }
        public int? codParcDest { get; set; }

    }
}