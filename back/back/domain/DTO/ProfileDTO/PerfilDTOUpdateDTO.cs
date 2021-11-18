using back.domain.entities;

namespace back.domain.DTO.ProfileDTO
{
    public class PerfilDTOUpdateDTO : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }

    }
}