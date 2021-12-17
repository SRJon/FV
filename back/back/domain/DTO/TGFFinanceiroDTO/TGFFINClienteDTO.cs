using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.DTO.TGFCABNotaDTO;
using back.domain.DTO.TSIEmpDTO;

namespace back.domain.DTO.TGFFinanceiroDTO
{
    public class TGFFINClienteDTO
    {
        public int nufin { get; set; }
        public int numnota { get; set; }
        public short codemp { get; set; }
        public string provisao { get; set; }
        public DateTime dtneg { get; set; }
        public DateTime? dtvenc { get; set; }
        public DateTime? dhbaixa { get; set; }
        public decimal vlrdesdob { get; set; }
        public string desdobramento { get; set; }
        public short recdesp { get; set; }
        public virtual TSIEMPDTONF Empresa { get; set; }
        public int? nunota { get; set; }
        public virtual TGFCABDevolucaoDTO TGFCAB { get; set; }
    }
}