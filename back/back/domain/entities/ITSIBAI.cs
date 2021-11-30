using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITSIBAI
    {
        public string NomeBai { get; set; }
        public int Codreg { get; set; }
        public DateTime Dtalter { get; set; }
        public string DescricaoCorreio { get; set; }
        public Nullable<int> Nuversao { get; set; }
    }
}