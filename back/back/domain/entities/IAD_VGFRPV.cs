using System;

namespace back.domain.entities
{
    public interface IAD_VGFRPV
    {
        public Int16 CODVEND { get; set; }
        public string NOMEVEND { get; set; }
        public int CODPARC { get; set; }
        public string NOMEPARC { get; set; }
        public string CGC_CPF { get; set; }
        public Nullable<int> ATRASO { get; set; }
    }
}