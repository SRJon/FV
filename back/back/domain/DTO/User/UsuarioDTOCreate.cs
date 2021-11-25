using System;
using back.domain.entities;
using back.DTO.Authentication;

namespace back.domain.DTO.User
{
    public class UsuarioDTOCreate
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int PerfilId { get; set; }
        public int? VendedorUCod { get; set; }
        public bool? AltSenha { get; set; }
        public DateTime? DtUltAltSenha { get; set; }
        public string LoginSnk { get; set; }
        public int? SGTSIUSU_USU_COD { get; set; }
        public string SenhaFV { get; set; }
    }
}