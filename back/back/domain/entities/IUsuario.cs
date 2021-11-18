using System;
using back.data.entities.User;
using back.DTO.Authentication;

namespace back.domain.entities
{
    public interface IUsuario
    {

        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int PerfilId { get; set; }
        public Nullable<int> VendedorUCod { get; set; }
        public Nullable<bool> AltSenha { get; set; }
        public Nullable<DateTime> DtUltAltSenha { get; set; }
        public string LoginSnk { get; set; }
        public Nullable<int> SGTSIUSU_USU_COD { get; set; }
        public string SenhaFV { get; set; }

        public UserAuthenticateDto ToDto();


    }
}