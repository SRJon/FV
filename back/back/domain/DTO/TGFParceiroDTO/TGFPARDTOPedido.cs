using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back.domain.entities;

namespace back.domain.DTO.TGFParceiroDTO
{
    public class TGFPARDTOPedido
    {
        public int codparc { get; set; }
        public short codvend { get; set; }
        public string nomeparc { get; set; }
        public string razaosocial { get; set; }
        public char tippessoa { get; set; }
        public int? codparcmatriz { get; set; }
        public int codend { get; set; }
        public string numend { get; set; }
        public string complemento { get; set; }
        public int codbai { get; set; }
        public int codcid { get; set; }
        public int codreg { get; set; }
        public string cep { get; set; }
        public string caixapostal { get; set; }
        public string telefone { get; set; }
        public short? ramal { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string identinscestad { get; set; }
        public string inscestadnauf { get; set; }
        public string cgc_cpf { get; set; }
        public decimal? limcred { get; set; }
        public string cliente { get; set; }
        public string classificms { get; set; }
    }
}