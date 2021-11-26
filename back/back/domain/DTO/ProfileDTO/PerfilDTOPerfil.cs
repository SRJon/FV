using System.Collections.Generic;
using back.data.entities.ProfileScreen;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.entities;

namespace back.domain.DTO.ProfileDTO
{
    public class PerfilDTOPerfil : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }

        public ICollection<PerfilTelaDTOProfiless> PerfilTela { get; set; }

    }
}