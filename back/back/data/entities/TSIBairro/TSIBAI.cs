using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.TSIBairro
{
    public class TSIBAI : ITSIBAI
    {
        [Key]
        [Column("CODBAI")]
        public int CodBai { get; set; }
        public string NomeBai { get; set; }
        public int Codreg { get; set; }
        public DateTime Dtalter { get; set; }
        public string DescricaoCorreio { get; set; }
        public int? Nuversao { get; set; }
    }
}