using System;

namespace back.domain.entities
{
    public interface ITGFPAR
    {
        public short Codvend { get; set; }
        public string Nomeparc { get; set; }
        public string Razaosocial { get; set; }
        public char Tippessoa { get; set; }
        public Nullable<int> Codparcmatriz { get; set; }
        public int Codend { get; set; }
        public string Numend { get; set; }
        public string Complemento { get; set; }
        public int Codbai { get; set; }
        public int Codcid { get; set; }
        public string Cep { get; set; }
        public string Caixapostal { get; set; }
        public string Telefone { get; set; }
        public Nullable<short> Ramal { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Identinscestad { get; set; }
        public string Inscestadnauf { get; set; }
        public string Cgc_cpf { get; set; }
        public decimal Limcred { get; set; }
        public string Cliente { get; set; }

    }
}