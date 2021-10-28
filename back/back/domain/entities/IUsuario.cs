using System;

namespace back.domain.entities
{
    public interface IUsuario
    {

        public long UsuarioId { get; set; }
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }
        public string UsuarioNome { get; set; }
        public string UsuarioEmail { get; set; }
        public bool UsuarioAtivo { get; set; }
        public long PerfilId { get; set; }
        public long SgVendedorUCod { get; set; }
        public DateTimeOffset UsuarioDtUltAltSenha { get; set; }

    }
}