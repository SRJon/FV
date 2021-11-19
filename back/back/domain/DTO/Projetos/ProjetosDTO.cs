using back.domain.entities;

namespace back.domain.DTO.Projetos
{
    public class ProjetosDTO : IProjetos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
