using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.AD_SOLCAN
{
    public class AD_SOLCANDTO : IAD_SOLCAN
    {
        public int NuNota { get; set; }
        public string Motivo { get; set; }
        public string Autorizacao { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public DateTime? DtAutorizacao { get; set; }
        public string Proposta { get; set; }
        public int? CodVend { get; set; }
        public string ContraProposta { get; set; }
        public string MotivoNegado { get; set; }
        public int? CodParc { get; set; }
        public int? Ad_PedidoId { get; set; }
    }
}