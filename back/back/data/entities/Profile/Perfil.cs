using System.Collections.Generic;
using back.data.entities.ProfileScreen;
using back.data.entities.User;

using back.domain.entities;

namespace back.data.entities.Profile
{
    public class Perfil : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }


        public virtual ICollection<Usuario> Usuario { get; set; }

        public virtual ICollection<PerfilTela> PerfilTela { get; set; }
    }
}