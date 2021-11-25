using System;
using back.domain.entities;

namespace back.data.entities.VIEW_AD_VGFRPV
{
    public class AD_VGFRPV : IAD_VGFRPV
    {
        public Int16 Codvend { get; set; }
        public string Nomvend { get; set; }
        public int Codparc { get; set; }
        public string Nomeparc { get; set; }
        public string Cgc_cpf { get; set; }
        public int? Atraso { get; set; }
    }
}