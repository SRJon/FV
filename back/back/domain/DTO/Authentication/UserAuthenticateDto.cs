using System;
using System.Collections.Generic;
using back.data.entities.User;
using back.domain.DTO.UserEmp;
using back.domain.entities;

namespace back.DTO.Authentication
{
    public class UserAuthenticateDto : IUsuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public int? PerfilId { get; set; }
        public int? VendedorUCod { get; set; }
        public bool? AltSenha { get; set; }
        public DateTime? DtUltAltSenha { get; set; }
        public string LoginSnk { get; set; }
        public int? sgtsiusU_USU_COD { get; set; }
        public string SenhaFV { get; set; }
        public string token { get; set; }
        public virtual ICollection<UsuarioEmpresaDTO> UsuarioEmp { get; set; }

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
                sgtsiusU_USU_COD = this.sgtsiusU_USU_COD,
                DtUltAltSenha = this.DtUltAltSenha
            };
        }

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
                sgtsiusU_USU_COD = this.sgtsiusU_USU_COD,
                DtUltAltSenha = this.DtUltAltSenha
            };
        }
    }
}
