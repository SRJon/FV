using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface IAD_DEVSOLICITACAO
    {
        public int Nusoldev { get; set; }
        public string TipFrete { get; set; }
        public Nullable<DateTime> DtNeg { get; set; }
        public string TipoDev { get; set; }
        public Nullable<int> NuNota { get; set; }
        public Nullable<int> CodParc { get; set; }
        public Nullable<int> CodEmp { get; set; }
        public string Desconto { get; set; }
        public Nullable<double> PercDesc { get; set; }
        public Nullable<int> CodVend { get; set; }
        public Nullable<int> NumNota_Old { get; set; }
        public Nullable<double> CodTipoPerdev { get; set; }
        public Nullable<double> Comissao { get; set; }
        public string Status { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string AutorizaDesc { get; set; }
        public string Observacao { get; set; }
        public Nullable<double> VlrOcorrencia { get; set; }
        public Nullable<int> Nrnfct { get; set; }
        public Nullable<double> Vlrct { get; set; }
        public Nullable<int> Volct { get; set; }
        public Nullable<double> Qtdct { get; set; }
        public string Enviadoct { get; set; }
        public Nullable<double> FreteDev { get; set; }
        public Nullable<int> CodBco { get; set; }
        public string CodAge { get; set; }
        public string CodOpbc { get; set; }
        public string CodcTabcoint { get; set; }
        public string Ar { get; set; }
        public string ParcMatriz { get; set; }

    }
}