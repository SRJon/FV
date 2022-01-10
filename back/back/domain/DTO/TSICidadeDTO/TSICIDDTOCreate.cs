using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.Abstract_Class;
using back.domain.entities;

namespace back.domain.DTO.TSICidadeDTO
{
    public class TSICIDDTOCreate : ToJsonClass, ITSICID
    {

        public short? Uf { get; set; }
        public string NomeCid { get; set; }
        public string Ddd { get; set; }
        public DateTime Dtalter { get; set; }
        // public int CodReg { get; set; }
    }
}