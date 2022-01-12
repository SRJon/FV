using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_SOLCAN
    {
        public int NuNota { get; set; }
        public string Motivo { get; set; }
        public string Autorizacao { get; set; }
        public Nullable<DateTime> DtSolicitacao { get; set; }
        public Nullable<DateTime> DtAutorizacao { get; set; }
        public string Proposta { get; set; }
        public Nullable<int> CodVend { get; set; }
        public string ContraProposta { get; set; }
        public string MotivoNegado { get; set; }
        public Nullable<int> CodParc { get; set; }
        public Nullable<int> Ad_PedidoId { get; set; }

    }
}