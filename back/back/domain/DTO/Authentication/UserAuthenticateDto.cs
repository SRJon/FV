using System;
using back.domain.entities;

namespace back.DTO.Authentication
{
    public class UserAuthenticateDto : IUsuario
    {

        public string Role { get; set; }
        public string Token { get; set; }
        public decimal UsuarioId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public bool UsuarioAtivo { get; set; }
        public decimal PerfilId { get; set; }
        public decimal? SgVendedorUCod { get; set; }
        public DateTime? UsuarioDtUltAltSenha { get; set; }
    }
}
