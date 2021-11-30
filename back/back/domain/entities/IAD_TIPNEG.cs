using System;

namespace back.domain.entities
{
    public interface IAD_TIPNEG
    {
        public Int16 CodTipVenda { get; set; }
        public Nullable<DateTime> DhAlter { get; set; }
        public string DescrTipVenda { get; set; }
        public char Ativo { get; set; }
        public char GrupoAutor { get; set; }
        public char Ad_LibRepresentate { get; set; }
        public Nullable<int> Media { get; set; }        
        public int Qtd_Parcelas { get; set; }
        public Nullable<Int16> CodParc { get; set; }
        public Nullable<Int16> Prim_Parc { get; set; }
    }
}
