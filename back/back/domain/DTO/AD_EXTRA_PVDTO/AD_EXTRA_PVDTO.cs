using back.domain.entities;

namespace back.domain.DTO.AD_EXTRA_PVDTO
{
    public class AD_EXTRA_PVDTO : IAD_EXTRA_PV
    {
        public int Nunota {get; set;}
        public double? Comissao { get; set; }
        public double? Valor_Pedido { get; set; }
        public string Observacao { get; set; }
        public string Ordem_Compra { get; set; }
        public string Venda_Direta { get; set; }
    }
}