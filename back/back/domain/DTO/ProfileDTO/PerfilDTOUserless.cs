using System.Collections.Generic;
using back.data.entities.ProfileScreen;
using back.domain.DTO.ProfileScreenDTO;
using back.domain.entities;

namespace back.domain.DTO.ProfileDTO
{
    public class PerfilDTOUserless : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }
        public int? PerfilId { get; set; }

    }
}