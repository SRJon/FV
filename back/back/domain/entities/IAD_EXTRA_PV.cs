using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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