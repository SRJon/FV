using System.ComponentModel.DataAnnotations.Schema;
using back.data.entities.Enterprise;
using back.domain.entities;

namespace back.data.entities.AnexoRep
{
    public class AnexoRep : IAnexoRep
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Extensao { get; set; }
        public int EmpresaId { get; set; }
        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }
    }
}
