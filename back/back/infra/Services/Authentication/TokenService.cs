using System.IdentityModel.Tokens.Jwt;
using back.DTO.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;
using System.Text;

namespace back.infra.Services.Authentication
{
    public static class TokenService
    {
        public static string GenerateToken(UserAuthenticateDto user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.PerfilId.ToString()),
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.Name, user.Ativo.ToString()),
                    new Claim(ClaimTypes.Name, user.DtUltAltSenha.ToString()),
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Name, user.Senha.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = signingCredentials
            };


            tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}