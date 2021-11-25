using back.data.entities.Enterprise;
using System;

namespace back.domain.entities
{
    public interface IInformativo
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public String Texto { get; set; }

        public int EmpresaId { get; set; }
    }
}
