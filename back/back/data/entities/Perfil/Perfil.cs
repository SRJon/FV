using back.domain.entities;

namespace back.data.entities.Perfil
{
    public class Perfil : IPerfil
    {
        public int Id { get; set; }
        public int? PerfilId { get; set; }
        public string Nome { get; set; }
        public int? PER_COD { get; set; }
    }
}
