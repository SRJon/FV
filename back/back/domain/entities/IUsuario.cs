using System;
using back.data.entities.User;
using back.DTO.Authentication;

namespace back.domain.entities
{
    public interface IUsuario
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

        public UserAuthenticateDto ToDto();
        public Usuario ToModel();

    }
}