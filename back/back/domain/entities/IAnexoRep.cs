using back.data.entities.Enterprise;

namespace back.domain.entities
{
    public interface IAnexoRep
    {   
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Extensao { get; set; }
        public Empresa ToModel();
    }
}
