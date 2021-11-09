using System;
using back.domain.entities;
using back.DTO.Authentication;

namespace back.data.entities.User
{
    public class Usuario : IUsuario
    {
        public int Id { get; set; }
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

        public UserAuthenticateDto ToDto()
        {
            return new UserAuthenticateDto()
            {
                Id = this.Id,
                Login = this.Login,
                Senha = this.Senha,
                Nome = this.Nome,
                Email = this.Email,
                Ativo = this.Ativo,
                PerfilId = this.PerfilId,
                SGTSIUSU_USU_COD = this.SGTSIUSU_USU_COD,
                DtUltAltSenha = this.DtUltAltSenha
            };
        }

        public Usuario ToModel()
        {
            return new Usuario()
            {
                Id = this.Id,
                Login = this.Login,
                Senha = this.Senha,
                Nome = this.Nome,
                Email = this.Email,
                Ativo = this.Ativo,
                PerfilId = this.PerfilId,
                SGTSIUSU_USU_COD = this.SGTSIUSU_USU_COD,
                DtUltAltSenha = this.DtUltAltSenha
            };
        }
    }
}