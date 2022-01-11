using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.AD_SOLCAN
{
    /// <summary>
    /// DTO da classe AD_SOLCAN(Solicitação de cancelamento)
    /// contendo apenas os itens necessários para criação da solicitação
    /// </summary>
    public class AD_SOLCANCreateDTO
    {
        public int NuNota { get; set; }
        public string Motivo { get; set; }
        public string Autorizacao { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public DateTime? DtAutorizacao { get; set; }
        public string Proposta { get; set; }
        public int? CodVend { get; set; }
        public string ContraProposta { get; set; }
        public int? CodParc { get; set; }
        public int? Ad_PedidoId { get; set; }
    }
}