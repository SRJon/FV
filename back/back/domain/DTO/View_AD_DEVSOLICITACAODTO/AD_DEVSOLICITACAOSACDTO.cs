using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TGFCABNotaDTO;
using back.domain.DTO.TGFParceiroDTO;
using back.domain.DTO.TSIEmpDTO;

namespace back.domain.DTO.View_AD_DEVSOLICITACAODTO
{
    public class AD_DEVSOLICITACAOSACDTO
    {
        public int Nusoldev { get; set; }
        public int? CodEmp { get; set; }
        public DateTime? DtNeg { get; set; }
        public string Status { get; set; }

        public virtual TGFCABSACDTO TGFCAB { get; set; }
        public virtual TSIEMPDTOSAC Empresa { get; set; }
        public virtual TGFPARSACDTO TGFPAR { get; set; }



    }
}