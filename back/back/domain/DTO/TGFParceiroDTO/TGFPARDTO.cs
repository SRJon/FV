using System.Collections.Generic;
using back.data.entities.Abstract_Class;
using back.domain.entities;

namespace back.domain.DTO.TGFParceiroDTO
{
    public class TGFPARDTO : ToJsonClass, ITGFPAR
    {
        public int Codparc { get; set; }
        public short Codvend { get; set; }
        public string Nomeparc { get; set; }
        public string Razaosocial { get; set; }
        public char Tippessoa { get; set; }
        public int? Codparcmatriz { get; set; }
        public int Codend { get; set; }
        public string Numend { get; set; }
        public string Complemento { get; set; }
        public int Codbai { get; set; }
        public int Codcid { get; set; }
        public int Codreg { get; set; }
        public string Cep { get; set; }
        public string Caixapostal { get; set; }
        public string Telefone { get; set; }
        public short? Ramal { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Identinscestad { get; set; }
        public string Inscestadnauf { get; set; }
        public string Cgc_cpf { get; set; }
        public decimal Limcred { get; set; }
        public string Cliente { get; set; }

        //Uso do front
        public virtual string Endereco { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Uf { get; set; }
        public virtual string Cidade { get; set; }
        public ICollection<string> Socios { get; set; }
    }
}