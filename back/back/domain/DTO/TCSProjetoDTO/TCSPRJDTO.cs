using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.TCSProjetoDTO
{
    public class TCSPRJDTO : ITCSPRJ
    {
        public int Codproj { get; set; }
        public int? Codprod { get; set; }
        public string Identificacao { get; set; }
        public string Abreviatura { get; set; }
        public string Ativo { get; set; }
        public short? Grau { get; set; }
        public int? Codprojpai { get; set; }
        public string Analitico { get; set; }
        public string Ad_Blolanc { get; set; }
    }
}