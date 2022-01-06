using System;

namespace back.domain.entities
{
    public interface IAD_PRODUTO_PV
    {
        public int Nunota { get; set; }
        public string Codigo_Cor { get; set; }
        public int Codigo_Produto { get; set; }
        public Nullable<double> Comissao { get; set; }
        public Nullable<double> Valor_Unitario { get; set; }
        public double Quantidade_Negociada { get; set; }
        public Nullable<double> Valor_Total { get; set; }
        public string Controle { get; set; }
        public string Descricao_Completa { get; set; }
        public string Tabela { get; set; }
        public string Hexa_Pantone { get; set; }
    }
}