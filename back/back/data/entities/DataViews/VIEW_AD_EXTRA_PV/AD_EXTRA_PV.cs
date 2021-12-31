using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.data.entities.DataViews.VIEW_AD_EXTRA_PV
{
    public class AD_EXTRA_PV
    {
        public int Nunota {get; set;}
        public double? Comissao { get; set; }
        public double? Valor_Pedido { get; set; }
        public string Observacao { get; set; }
        public string Ordem_Compra { get; set; }
        public string Venda_Direta { get; set; }
    }
}