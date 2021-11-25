using back.data.entities.Enterprise;
using back.domain.entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.data.entities.Informativo
{
    public class Informativo : IInformativo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Texto { get; set; }
        public int EmpresaId { get; set; }
        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }
    }
}
