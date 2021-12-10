using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TGFContatoDTO;
using back.domain.DTO.TGFParceiroDTO;

namespace back.domain.DTO.TGFPAR_TGFCTT
{
    public class TGFPAR_TGFCTTDTO
    {
        public TGFPARDTO Cliente { get; set; }
        public ICollection<TGFCTTDTOCreate> Compradores { get; set; }
    }
}