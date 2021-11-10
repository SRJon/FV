using back.domain.entities;

namespace back.data.entities.Profile
{
    public class Perfil : IPerfil
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }
        public int? PerfilId { get; set; }
    }
}