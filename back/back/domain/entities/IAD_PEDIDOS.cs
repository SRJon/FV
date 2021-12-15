using System;

namespace back.domain.entities
{
    public interface IAD_PEDIDOS
    {
        public string Confirmada { get; set; }
        public int Nunota { get; set; }
        public Nullable<DateTime> DtEmisssao { get; set; }
        public Nullable<int> NumeroPedido { get; set; }
        public int NumeroNota { get; set; }
        public string NomeParc { get; set; }
        public int CodParc { get; set; }
        public string CodTioper_DescrOper { get; set; }
        public int CodProj { get; set; }
        public Nullable<double> VlrNota { get; set; }
        public int DestinoParc { get; set; }
        public string OrdemCompra { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> BolDiasVenc { get; set; }
        public Nullable<DateTime> DtCartao { get; set; }
        public Nullable<DateTime> CalcPrazo { get; set; }
        public string VendaDireta { get; set; }
    }
}