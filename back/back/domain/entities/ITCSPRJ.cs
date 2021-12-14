using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITCSPRJ
    {
        public int Codproj { get; set; }
        public Nullable<int> Codprod { get; set; }
        public string Identificacao { get; set; }
        public string Abreviatura { get; set; }
        public string Ativo { get; set; }
        public Nullable<short> Grau { get; set; }
        public Nullable<int> Codprojpai { get; set; }
        public string Analitico { get; set; }
        public string Ad_Blolanc { get; set; }
    }
}