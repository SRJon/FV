using back.domain.DTO.Enterprise;
using back.domain.entities;

namespace back.domain.DTO.AnexoRep
{
    public class AnexoRepDTO : IAnexoRep
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Extensao { get; set; }
        public int EmpresaId { get; set; }
        public virtual EmpresaDTO Empresa { get; set; }
    }
}

