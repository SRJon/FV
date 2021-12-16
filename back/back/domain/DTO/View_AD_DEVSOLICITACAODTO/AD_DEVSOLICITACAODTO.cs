using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.View_AD_DEVSOLICITACAODTO
{
    public class AD_DEVSOLICITACAODTO : IAD_DEVSOLICITACAO
    {
        public int Nusoldev { get; set; }
        public string TipFrete { get; set; }
        public DateTime? DtNeg { get; set; }
        public string TipoDev { get; set; }
        public int? NuNota { get; set; }
        public int? CodParc { get; set; }
        public int? CodEmp { get; set; }
        public string Desconto { get; set; }
        public double? PercDesc { get; set; }
        public int? CodVend { get; set; }
        public int? NumNota_Old { get; set; }
        public double? CodTipoPerdev { get; set; }
        public double? Comissao { get; set; }
        public string Status { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string AutorizaDesc { get; set; }
        public string Observacao { get; set; }
        public double? VlrOcorrencia { get; set; }
        public int? Nrnfct { get; set; }
        public double? Vlrct { get; set; }
        public int? Volct { get; set; }
        public double? Qtdct { get; set; }
        public string Enviadoct { get; set; }
        public double? FreteDev { get; set; }
        public int? CodBco { get; set; }
        public string CodAge { get; set; }
        public string CodOpbc { get; set; }
        public string CodcTabcoint { get; set; }
        public string Ar { get; set; }
        public string ParcMatriz { get; set; }
    }
}