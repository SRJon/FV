using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.View_AD_PEDIDOCANCELAMENTO
{
    public class AD_PEDIDOCANCELAMENTO : IAD_PEDIDOCANCELAMENTO
    {
        public int Ped_Nunota { get; set; }
        public short Codvend { get; set; }
        public string StatusLit { get; set; }
        public string Motivo { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public DateTime? DtAutorizacao { get; set; }
        public string Autorizacao { get; set; }
        public string Proposta { get; set; }
        public string Contraproposta { get; set; }
        public int? Pedad_PedidoId { get; set; }
        public string PedNomeParc { get; set; }
        public int? PedCodProj { get; set; }
        public string PedEstoqueAbrv { get; set; }
        public double? PedVlrPedido { get; set; }
        public string Status_ped { get; set; }
        public DateTime? DataFatur { get; set; }
        public int? CodParc { get; set; }
        public int? Nota_NumNota { get; set; }
    }
}