using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.ViewAD_FINCOM
{
    public class AD_FINCOM : IAD_FINCOM
    {
        public short codemp { get; set; }
        public string empresa { get; set; }
        public int nufim { get; set; }
        public short? codvend { get; set; }
        public int codparc { get; set; }
        public string nomeparc { get; set; }
        public string codagencia { get; set; }
        public string contabancaria { get; set; }
        public string nomebco { get; set; }
        public DateTime? dtvenc { get; set; }
        public decimal vlrdesdob { get; set; }
        public DateTime? dhbaixa { get; set; }
        public int? mes_ref { get; set; }
        public int? ano_ref { get; set; }
        public string calc_ir { get; set; }
        public double vlr_ir { get; set; }
        public string usuario { get; set; }
        public double? vlrliquido { get; set; }
    }
}