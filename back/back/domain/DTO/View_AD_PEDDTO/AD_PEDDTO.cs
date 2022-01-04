using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.View_AD_PEDDTO
{
    public class AD_PEDDTO : IAD_PED
    {
        public short codemp { get; set; }
        public string nomefantasia { get; set; }
        public int codparc { get; set; }
        public string nomeparc { get; set; }
        public short codvend { get; set; }
        public string nomevend { get; set; }
        public int pedNunota { get; set; }
        public int? pedNumnota { get; set; }
        public DateTime? dtneg { get; set; }
        public string tipmov { get; set; }
        public double? vlrpedido { get; set; }
        public string adStatus { get; set; }
        public int? adPedidoid { get; set; }
        public int? codproj { get; set; }
        public short codtipvenda { get; set; }
        public string descrtipvenda { get; set; }
        public string estoque { get; set; }
        public string estoqueAbreviado { get; set; }
        public int? notaNunota { get; set; }
        public int? notaNumnota { get; set; }
        public double? vlrnota { get; set; }
        public DateTime? datafatur { get; set; }
        public int? codParcDest { get; set; }
        public string nomeParcDest { get; set; }
        public int? notaRemNuNota { get; set; }
        public int? notaRemNumNota { get; set; }
        public int? codparcTransp { get; set; }
        public string nomeparcTransp { get; set; }
        public string cancelado { get; set; }
        public string motvcanc { get; set; }
        public DateTime? dtmov { get; set; }
        public string statusPed { get; set; }
    }
}