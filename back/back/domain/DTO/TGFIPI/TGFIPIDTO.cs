using back.domain.entities;
using System;

namespace back.domain.DTO.TGFIPI
{
    public class TGFIPIDTO : ITGFIPI
    {
        public short CodIpi { get; set; }
        public string CodFisIpi { get; set; }
        public double? Percentual { get; set; }
        public decimal? VlrPauta { get; set; }
        public string Descricao { get; set; }
        public short CodExNcm { get; set; }
        public short CodExii { get; set; }
        public double? Aliqii { get; set; }
        public double? PercPis { get; set; }
        public double? PercCofins { get; set; }
        public double? PercCssl { get; set; }
        public double? AliqIcms { get; set; }
        public short? CstIpiEnt { get; set; }
        public short? CstIpiSai { get; set; }
        public string CodStii { get; set; }
        public double? PercImportacao { get; set; }
        public short? CodEnqIpiEnt { get; set; }
        public short? CodEnqIpiSai { get; set; }
        public double? PerCredVlrIpi { get; set; }
    }
}
