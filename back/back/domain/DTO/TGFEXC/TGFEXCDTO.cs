using back.domain.entities;
using System;

namespace back.domain.DTO.TGFEXC
{
    public class TGFEXCDTO : ITGFEXC
    {
        public int NuTab { get; set; }
        public int CodProd { get; set; }
        public int CodLocal { get; set; }
        public string Controle { get; set; }
        public double? VlrVenda { get; set; }
        public string Tipo { get; set; }
        public string ModBaseIcms { get; set; }
        public double? PercDesc { get; set; }
        public double? MargLucro { get; set; }
        public double? PercCom { get; set; }
        public string Ad_Observacao { get; set; }
        public double? Ad_Comissao { get; set; }
        public double? Ad_VlrVenda_Old { get; set; }
        public int? Ad_Cod_Tag { get; set; }
        public string Ad_Desconto_Esp { get; set; }
        public int? Ad_Moeda { get; set; }
        public int? Ad_CodProj { get; set; }
    }
}
