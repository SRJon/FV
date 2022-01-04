using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_PED
    {
        public short codemp { get; set; }
        public string nomefantasia { get; set; }
        public int codparc { get; set; }
        public string nomeparc { get; set; }
        public short codvend { get; set; }
        public string nomevend { get; set; }
        public int pedNunota { get; set; }
        public Nullable<int> pedNumnota { get; set; }
        public Nullable<DateTime> dtneg { get; set; }
        public string tipmov { get; set; }
        public Nullable<double> vlrpedido { get; set; }
        public string adStatus { get; set; }
        public Nullable<int> adPedidoid { get; set; }
        public Nullable<int> codproj { get; set; }
        public short codtipvenda { get; set; }
        public string descrtipvenda { get; set; }
        public string estoque { get; set; }
        public string estoqueAbreviado { get; set; }
        public Nullable<int> notaNunota { get; set; }
        public Nullable<int> notaNumnota { get; set; }
        public Nullable<double> vlrnota { get; set; }
        public Nullable<DateTime> datafatur { get; set; }
        public Nullable<int> codParcDest { get; set; }
        public string nomeParcDest { get; set; }
        public Nullable<int> notaRemNuNota { get; set; }
        public Nullable<int> notaRemNumNota { get; set; }
        public Nullable<int> codparcTransp { get; set; }
        public string nomeparcTransp { get; set; }
        public string cancelado { get; set; }
        public string motvcanc { get; set; }
        public Nullable<DateTime> dtmov { get; set; }
        public string statusPed { get; set; }

    }
}