using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.TSIBairroDTO
{
    public class TSIBAIDTO : ITSIBAI
    {
        public int CodBai { get; set; }
        public string NomeBai { get; set; }
        public int Codreg { get; set; }
        public DateTime Dtalter { get; set; }
        public string DescricaoCorreio { get; set; }
        public int? Nuversao { get; set; }
    }
}