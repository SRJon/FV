using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.AD_STATUSLit
{
    public class AD_STATUS : IAD_STATUS
    {
        [Key]
        [Column("NUNOTA")]
        public int Nunota { get; set; }
        public string StatusLit { get; set; }
    }
}