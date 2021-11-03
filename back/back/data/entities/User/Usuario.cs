using System;
using back.domain.entities;
using back.DTO.Authentication;

namespace back.data.entities.User
{
    public class Usuario : IUsuario
    {
        public decimal UsuarioId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public bool UsuarioAtivo { get; set; }
        public decimal PerfilId { get; set; }
        public Nullable<decimal> SgVendedorUCod { get; set; }
        public Nullable<DateTime> UsuarioDtUltAltSenha { get; set; }

        public UserAuthenticateDto ToDto()
        {
            return new UserAuthenticateDto()
            {
                UsuarioId = this.UsuarioId,
                UsuarioLogin = this.UsuarioLogin,
                UsuarioSenha = this.UsuarioSenha,
                UsuarioNome = this.UsuarioNome,
                UsuarioEmail = this.UsuarioEmail,
                UsuarioAtivo = this.UsuarioAtivo,
                PerfilId = this.PerfilId,
                SgVendedorUCod = this.SgVendedorUCod,
                UsuarioDtUltAltSenha = this.UsuarioDtUltAltSenha
            };
        }

        public Usuario ToModel()
        {
            return new Usuario()
            {
                UsuarioId = this.UsuarioId,
                UsuarioLogin = this.UsuarioLogin,
                UsuarioSenha = this.UsuarioSenha,
                UsuarioNome = this.UsuarioNome,
                UsuarioEmail = this.UsuarioEmail,
                UsuarioAtivo = this.UsuarioAtivo,
                PerfilId = this.PerfilId,
                SgVendedorUCod = this.SgVendedorUCod,
                UsuarioDtUltAltSenha = this.UsuarioDtUltAltSenha
            };
        }
    }
}