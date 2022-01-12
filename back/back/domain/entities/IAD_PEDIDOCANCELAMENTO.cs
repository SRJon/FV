using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_PEDIDOCANCELAMENTO
    {
        public int Ped_Nunota { get; set; }
        public short Codvend { get; set; }
        public string StatusLit { get; set; }
        public string Motivo { get; set; }
        public Nullable<DateTime> DtSolicitacao { get; set; }
        public Nullable<DateTime> DtAutorizacao { get; set; }
        public string Autorizacao { get; set; }
        public string Proposta { get; set; }
        public string Contraproposta { get; set; }
        public Nullable<int> Pedad_PedidoId { get; set; }
        public string PedNomeParc { get; set; }
        public Nullable<int> PedCodProj { get; set; }
        public string PedEstoqueAbrv { get; set; }
        public Nullable<double> PedVlrPedido { get; set; }
        public string Status_ped { get; set; }
        public Nullable<DateTime> DataFatur { get; set; }
        public Nullable<int> CodParc { get; set; }
        public Nullable<int> Nota_NumNota { get; set; }
    }
}