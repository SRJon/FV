using back.domain.entities;
using System;

namespace back.domain.DTO.TGFRGV
{
    public class TGFRGVDTOUpdateDTO : ITGFRGV
    {
        public int CODGRUPOPROD { get; set; }
        public short CODVEND { get; set; }
        public DateTime? AD_DTMIGRA { get; set; }
    }
}
