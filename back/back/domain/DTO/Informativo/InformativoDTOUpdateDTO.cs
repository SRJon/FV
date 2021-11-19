using back.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.Informativo
{
    public class InformativoDTOUpdateDTO : IInformativo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Texto { get; set; }
        public int EmpresaId { get; set; }
    }
}

