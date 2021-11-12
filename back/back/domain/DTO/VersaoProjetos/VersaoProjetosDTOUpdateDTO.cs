using back.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.VersaoProjetos
{
    public class VersaoProjetosDTOUpdateDTO : IVersaoProjetos
    {
        public int Id { get; set; }
        public string Versao { get; set; }
        public int? ProjId { get; set; }
        public DateTime? Data { get; set; }
        
    }
}
