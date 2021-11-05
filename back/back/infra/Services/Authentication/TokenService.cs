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
            var expires = DateTime.Now;
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.PrimarySid, user.PerfilId.ToString()),
                }),
                Expires = expires.AddHours(1),
                NotBefore = expires,
                SigningCredentials = signingCredentials,


            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string RefreshToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // ClockSkew = TimeSpan.Zero,

            };

            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var securityToken);
            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                throw new SecurityTokenException("Invalid token");

            var userId = principal.FindFirst(ClaimTypes.PrimarySid)?.Value;
            if (string.IsNullOrEmpty(userId))
                throw new SecurityTokenException("Invalid token");

            var newToken = GenerateToken(new UserAuthenticateDto { PerfilId = int.Parse(userId) });
            return newToken;
        }


    }
}