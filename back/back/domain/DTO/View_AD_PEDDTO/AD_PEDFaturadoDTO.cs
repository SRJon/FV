using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.DTO.View_AD_PEDDTO
{
    public class AD_PEDFaturadoDTO
    {
        public int pedNunota { get; set; }
        public string statusPed { get; set; }
        public DateTime? datafatur { get; set; }
    }
}