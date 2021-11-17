using back.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.Projetos
{
    public class ProjetosDTOUpdateDTO : IProjetos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
