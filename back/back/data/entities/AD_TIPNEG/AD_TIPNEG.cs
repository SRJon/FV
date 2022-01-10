using back.domain.entities;
using System;

namespace back.data.entities.View_AD_TIPNEG
{
    public class AD_TIPNEG : IAD_TIPNEG
    {
        public short CodTipVenda { get; set; }
        public DateTime? DhAlter { get; set; }
        public string DescrTipVenda { get; set; }
        public char Ativo { get; set; }
        public char GrupoAutor { get; set; }
        public char Ad_LibRepresentate { get; set; }
        public int? Media { get; set; }
        public int Qtd_Parcelas { get; set; }
        public short? CodParc { get; set; }
        public short? Prim_Parc { get; set; }
    }
}

