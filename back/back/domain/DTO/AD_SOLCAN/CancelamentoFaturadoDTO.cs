using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.AD_SOLCAN
{
    /// <summary>
    /// Classe de verificação da solicitação de cancelamento
    /// Se é válida e se está faturada
    /// </summary>
    public class CancelamentoFaturadoDTO
    {
        public bool isValid { get; set; }
        public bool Faturado { get; set; }
        public bool ValidRequisition { get; set; }

    }
}