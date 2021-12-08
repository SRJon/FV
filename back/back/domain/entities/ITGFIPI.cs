using System;

namespace back.domain.entities
{
    public interface ITGFIPI
    {
        public short CodIpi { get; set; }
        public string CodFisIpi { get; set; }
        public Nullable<double> Percentual { get; set; }
        public Nullable<decimal> VlrPauta { get; set; }
        public string Descricao { get; set; }
        public short CodExNcm { get; set; }
        public short CodExii { get; set; }
        public Nullable<double> Aliqii { get; set; }
        public Nullable<double> PercPis { get; set; }
        public Nullable<double> PercCofins { get; set; }
        public Nullable<double> PercCssl { get; set; }
        public Nullable<double> AliqIcms { get; set; }
        public Nullable<short> CstIpiEnt { get; set; }
        public Nullable<short> CstIpiSai { get; set; }
        public string CodStii { get; set; }
        public Nullable<double> PercImportacao { get; set; }
        public Nullable<short> CodEnqIpiEnt { get; set; }
        public Nullable<short> CodEnqIpiSai { get; set; }
        public Nullable<double> PerCredVlrIpi { get; set; }
    }
}
