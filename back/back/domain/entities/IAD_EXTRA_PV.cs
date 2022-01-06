using System;

namespace back.domain.entities
{
    public interface IAD_EXTRA_PV
    {
        public int Nunota {get; set;}
        public Nullable<double> Comissao { get; set; }
        public Nullable<double> Valor_Pedido { get; set; }
        public string Observacao { get; set; }
        public string Ordem_Compra { get; set; }
        public string Venda_Direta { get; set; }
    }
}