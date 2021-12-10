using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Abstract_Class;
using back.domain.entities;

namespace back.domain.DTO.TSIBairroDTO
{
    public class TSIBAIDTOCreate : ToJsonClass, ITSIBAI
    {
        public string NomeBai { get; set; }
        public int Codreg { get; set; }
        public DateTime Dtalter { get; set; }
        public string DescricaoCorreio { get; set; }
        public int? Nuversao { get; set; }
    }
}