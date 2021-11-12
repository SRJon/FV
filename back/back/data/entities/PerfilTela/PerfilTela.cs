using back.data.entities.Screen;
using back.data.entities.Perfil;
using System;
using back.domain.entities;

namespace back.data.entities.PerfilTela
{
    public class PerfilTela : IPerfilTela
    {
        public int Id { get; set; }
        public int? PerfilId { get; set; }
        public int TelaId { get; set; }
        public bool INS { get; set; }
        public bool DSP { get; set; }
        public bool UPD { get; set; }
        public bool DLT { get; set; }
    }
}
