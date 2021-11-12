using back.domain.entities;
using System.ComponentModel.DataAnnotations;

namespace back.data.entities.Projetos
{
    public class Projetos : IProjetos

    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
