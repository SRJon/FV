using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.domain.entities
{
    public interface ITGFCTT
    {
        public int Codparc { get; set; }
        public int CodContato { get; set; }
        public string NomeContato { get; set; }//COMPRADOR
        public string Apelido { get; set; }
        public string Cargo { get; set; }
        public Nullable<int> CodEnd { get; set; }
        public string NumEnd { get; set; }
        public string Complemento { get; set; }
        public Nullable<int> CodBai { get; set; }
        public Nullable<int> CodCid { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }//COMPRADOR
        public Nullable<short> Ramal { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }//COMPRADOR
        public Nullable<DateTime> DtNasc { get; set; }
        public string CPF { get; set; }
        public Nullable<int> Prioridade { get; set; }
        public string Ativo { get; set; }
        public Nullable<DateTime> DtCad { get; set; }
        public string Celular { get; set; }//COMPRADOR

    }
}