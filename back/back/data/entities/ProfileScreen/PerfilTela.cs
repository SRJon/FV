using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; }
        [ForeignKey("TelaId")]
        public virtual ICollection<Tela> Telas { get; set; }
    }
}