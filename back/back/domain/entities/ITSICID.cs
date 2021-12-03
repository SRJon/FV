using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITSICID
    {
        public int CodCid { get; set; }
        public Nullable<short> Uf { get; set; }
        public string NomeCid { get; set; }
        public string Ddd { get; set; }
        // public int CodReg { get; set; }
        public DateTime Dtalter { get; set; }
    }
}