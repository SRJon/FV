using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.data.entities.TGFContato
{
    public class TGFCTT : ITGFCTT
    {
        [Key]
        [Column("CODPARC")]
        public int Codparc { get; set; }
        [Key]
        [Column("CODCONTATO")]
        public int CodContato { get; set; }
        public string NomeContato { get; set; }
        public string Apelido { get; set; }
        public string Cargo { get; set; }
        public int? CodEnd { get; set; }
        public string NumEnd { get; set; }
        public string Complemento { get; set; }
        public int? CodBai { get; set; }
        public int? CodCid { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public short? Ramal { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public DateTime? DtNasc { get; set; }
        public string CPF { get; set; }
        public int? Prioridade { get; set; }
        public string Ativo { get; set; }
        public DateTime? DtCad { get; set; }
        public string Celular { get; set; }
    }
}