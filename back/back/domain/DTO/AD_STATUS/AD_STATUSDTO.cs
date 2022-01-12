using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.AD_STATUS
{
    public class AD_STATUSDTO : IAD_STATUS
    {
        public int Nunota { get; set; }
        public string StatusLit { get; set; }
    }
}