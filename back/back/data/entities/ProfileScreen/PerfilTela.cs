using System.Collections.Generic;
using back.data.entities.Profile;
using back.data.entities.Screen;
using back.domain.entities;

namespace back.data.entities.ProfileScreen
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


        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<Tela> Tela { get; set; }
    }
}