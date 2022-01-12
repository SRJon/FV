using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.AD_SOLCAN
{
    public class AD_SOLCancelamentoDTO
    {
        public int NuNota { get; set; }
        public string Motivo { get; set; }
        public string Autorizacao { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public DateTime? DtAutorizacao { get; set; }
        public string Proposta { get; set; }
        public string ContraProposta { get; set; }
    }
}