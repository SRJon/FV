using back.domain.entities;
using back.data.entities.User;
using back.domain.DTO.User;
using System.Collections.Generic;
using back.domain.DTO.ProfileScreenDTO;

namespace back.domain.DTO.ProfileDTO
{
    public class PerfilDTO : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }
        public int? PerfilId { get; set; }


        public virtual ICollection<PerfilTelaDTOProfiless> PerfilTela { get; set; }
        public virtual ICollection<UsuarioDTO> Usuario { get; set; }

    }
}