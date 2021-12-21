using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_FINCOM
    {
        public short codemp { get; set; }
        public string empresa { get; set; }
        public int nufim { get; set; }
        public Nullable<short> codvend { get; set; }
        public int codparc { get; set; }
        public string nomeparc { get; set; }
        public string codagencia { get; set; }
        public string contabancaria { get; set; }
        public string nomebco { get; set; }
        public Nullable<DateTime> dtvenc { get; set; }
        public decimal vlrdesdob { get; set; }
        public Nullable<DateTime> dhbaixa { get; set; }
        public Nullable<int> mes_ref { get; set; }
        public Nullable<int> ano_ref { get; set; }
        public string calc_ir { get; set; }
        public double vlr_ir { get; set; }
        public string usuario { get; set; }
        public Nullable<double> vlrliquido { get; set; }
    }
}