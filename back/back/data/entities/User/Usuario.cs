using System;
using System.ComponentModel.DataAnnotations.Schema;
using back.data.entities.Profile;
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
        public int? VendedorUCod { get; set; }
        public bool? AltSenha { get; set; }
        public DateTime? DtUltAltSenha { get; set; }
        public string LoginSnk { get; set; }
        [Column("SGTSIUSU_USU_COD")]
        public int? sgtsiusU_USU_COD { get; set; }
        public string SenhaFV { get; set; }
        public int? PerfilId { get; set; }
        [ForeignKey("PerfilId")]
        public virtual Perfil Perfil { get; set; }        

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
                PerfilId = (int)this.PerfilId,
                sgtsiusU_USU_COD = this.sgtsiusU_USU_COD,
                DtUltAltSenha = this.DtUltAltSenha
            };
        }
    }
}