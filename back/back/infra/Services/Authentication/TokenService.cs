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
            return "";
        }

    }
}