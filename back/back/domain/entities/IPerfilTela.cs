using System;

namespace back.domain.entities
{
    public interface IPerfilTela
    {
        public int Id { get; set; }
        public Nullable<int> PerfilId { get; set; }
        public int TelaId { get; set; }
        public bool INS { get; set; }
        public bool DSP { get; set; }
        public bool UPD { get; set; }
        public bool DLT { get; set; }
    }
}