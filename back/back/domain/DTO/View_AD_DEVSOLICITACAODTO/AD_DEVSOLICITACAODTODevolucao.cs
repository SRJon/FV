using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.data.entities.TGFCABNota;
using back.data.entities.TSIEmpresa;
using back.domain.DTO.TGFCABNotaDTO;
using back.domain.DTO.TSIEmpDTO;
using back.domain.entities;

namespace back.domain.DTO.View_AD_DEVSOLICITACAODTO
{
    public class AD_DEVSOLICITACAODTODevolucao
    {
        public int Nusoldev { get; set; }
        public int? CodParc { get; set; }
        public DateTime? DtNeg { get; set; }
        public string TipoDev { get; set; }
        public int? CodEmp { get; set; }
        public int? NuNota { get; set; }
        public string Desconto { get; set; }
        public double? PercDesc { get; set; }
        public double? Comissao { get; set; }
        public virtual TSIEMPDevolucaoDTO Empresa { get; set; }
        public virtual TGFCABDevolucaoDTO TGFCAB { get; set; }


    }
}