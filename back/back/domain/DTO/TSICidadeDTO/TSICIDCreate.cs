using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.TSICidadeDTO
{
    public class TSICIDCreate : ITSICID
    {
        public int CodCid { get; set; }
        public short? Uf { get; set; }
        public string NomeCid { get; set; }
        public string Ddd { get; set; }
        public DateTime Dtalter { get; set; }
        // public int CodReg { get; set; }
    }
}