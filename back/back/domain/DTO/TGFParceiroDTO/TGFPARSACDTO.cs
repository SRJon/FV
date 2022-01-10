using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TSICidadeDTO;

namespace back.domain.DTO.TGFParceiroDTO
{
    public class TGFPARSACDTO
    {
        public int codparc { get; set; }
        public short codvend { get; set; }
        public string nomeparc { get; set; }
        public int codcid { get; set; }
        public virtual TSICIDSACDTO tsicid { get; set; }
    }
}