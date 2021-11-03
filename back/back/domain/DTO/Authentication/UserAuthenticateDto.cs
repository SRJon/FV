using System;
using back.data.entities.User;
using back.domain.entities;

namespace back.DTO.Authentication
{
    public class UserAuthenticateDto : IUsuario
    {
        public decimal UsuarioId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public bool UsuarioAtivo { get; set; }
        public decimal PerfilId { get; set; }
        public decimal? SgVendedorUCod { get; set; }
        public DateTime? UsuarioDtUltAltSenha { get; set; }



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
    }
}
