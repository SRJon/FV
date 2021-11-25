using System;

namespace back.domain.entities
{
    public interface IAD_VGFRPV
    {
        public Int16 Codvend { get; set; }
        public string Nomvend { get; set; }
        public int Codparc { get; set; }
        public string Nomeparc { get; set; }
        public string Cgc_cpf { get; set; }
        public Nullable<int> Atraso { get; set; }
    }
}