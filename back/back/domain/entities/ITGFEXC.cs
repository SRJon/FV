using System;

namespace back.domain.entities
{
    public interface ITGFEXC
    {
        public int NuTab { get; set; }
        public int CodProd { get; set; }
        public int CodLocal { get; set; }
        public string Controle { get; set; }
        public Nullable<double> VlrVenda { get; set; }
        public string Tipo { get; set; }
        public string ModBaseIcms { get; set; }
        public Nullable<double> PercDesc { get; set; }
        public Nullable<double> MargLucro { get; set; }
        public Nullable<double> PercCom { get; set; }
        public string Ad_Observacao { get; set; }
        public Nullable<double> Ad_Comissao { get; set; }
        public Nullable<double> Ad_VlrVenda_Old { get; set; }
        public Nullable<int> Ad_Cod_Tag { get; set; }
        public string Ad_Desconto_Esp { get; set; }
        public Nullable<int> Ad_Moeda { get; set; }
        public Nullable<int> Ad_CodProj { get; set; }
    }
}
