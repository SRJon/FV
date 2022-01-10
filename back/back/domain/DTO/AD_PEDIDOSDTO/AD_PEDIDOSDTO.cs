using System;
using back.domain.entities;

namespace back.domain.DTO.AD_PEDIDOSDTO
{
    public class AD_PEDIDOSDTO : IAD_PEDIDOS
    {
        public string Confirmada { get; set; }
        public int Nunota { get; set; }
        public DateTime? DtEmisssao { get; set; }
        public int? NumeroPedido { get; set; }
        public int NumeroNota { get; set; }
        public string NomeParc { get; set; }
        public int CodParc { get; set; }
        public string CodTioper_DescrOper { get; set; }
        public int CodProj { get; set; }
        public double? VlrNota { get; set; }
        public int DestinoParc { get; set; }
        public string OrdemCompra { get; set; }
        public string Observacao { get; set; }
        public int? BolDiasVenc { get; set; }
        public DateTime? DtCartao { get; set; }
        public DateTime? CalcPrazo { get; set; }
        public string VendaDireta { get; set; }
    }
}