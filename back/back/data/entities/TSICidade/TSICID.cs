using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.TSICidade
{
    public class TSICID : ITSICID
    {
        [Key]
        [Column("CODCID")]
        public int CodCid { get; set; }
        public short? Uf { get; set; }
        public string NomeCid { get; set; }
        public string Ddd { get; set; }
        public DateTime Dtalter { get; set; }
        // public int CodReg { get; set; }
    }
}