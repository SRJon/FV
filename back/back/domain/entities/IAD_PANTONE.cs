using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_PANTONE
    {
        public int CodCor { get; set; }
        public string CodHex { get; set; }
        public Nullable<int> Pagina { get; set; }
        public string CodCor2 { get; set; }
        public Nullable<int> CodGrupoCor { get; set; }
        public string CodPantone { get; set; }
        public string NomeCor { get; set; }
        public string Estampado { get; set; }

    }
}
