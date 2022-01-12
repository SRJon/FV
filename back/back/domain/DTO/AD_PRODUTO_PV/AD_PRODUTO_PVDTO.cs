using back.domain.entities;

namespace back.domain.DTO.AD_PRODUTO_PV
{
    public class AD_PRODUTO_PVDTO : IAD_PRODUTO_PV
    {
        public int Nunota { get; set; }
        public string Codigo_Cor { get; set; }
        public int Codigo_Produto { get; set; }
        public double? Comissao { get; set; }
        public double? Valor_Unitario { get; set; }
        public double Quantidade_Negociada { get; set; }
        public double? Valor_Total { get; set; }
        public string Controle { get; set; }
        public string Descricao_Completa { get; set; }
        public string Tabela { get; set; }
        public string Hexa_Pantone { get; set; }
    }
}