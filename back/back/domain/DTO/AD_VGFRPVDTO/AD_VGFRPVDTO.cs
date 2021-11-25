using System;
using back.domain.entities;

namespace back.domain.DTO.AD_VGFRPVDTO
{
    public class AD_VGFRPVDTO : IAD_VGFRPV
    {
        public Int16 Codvend { get; set; }
        public string Nomvend { get; set; }
        public int Codparc { get; set; }
        public string Nomeparc { get; set; }
        public string Cgc_cpf { get; set; }
        public int? Atraso { get; set; }
    }
}