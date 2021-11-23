using System;
using back.domain.entities;

namespace back.data.entities.VIEW_AD_VGFRPV
{
    public class AD_VGFRPV : IAD_VGFRPV
    {
        public Int16 CODVEND { get; set; }
        public string NOMEVEND { get; set; }
        public int CODPARC { get; set; }
        public string NOMEPARC { get; set; }
        public string CGC_CPF { get; set; }
        public int? ATRASO { get; set; }
    }
}