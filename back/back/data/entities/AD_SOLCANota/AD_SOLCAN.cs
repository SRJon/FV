using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.View_AD_PED;
using back.domain.entities;

namespace back.data.entities.AD_SOLCANota
{
    public class AD_SOLCAN : IAD_SOLCAN
    {
        [Key]
        [Column("NUNOTA")]
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
        //public virtual AD_PED AD_PED { get; set; }
    }
}