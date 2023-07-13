using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WMS.Sisdep.Domain.Core.Models;

namespace WMS.Sisdep.Application.Core.Helpers
{
    public static class TokenHelper
    {
        public static string Generate(UsuarioModel usuario, string grupo, string empresa, IConfiguration configuration)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(configuration["Token:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = "",
                Audience = "SISDEP",
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("id", usuario.Id.ToString()),
                    new Claim("grupo", grupo),
                    new Claim("empresa", empresa),
                    new Claim("usuario", usuario.Usuario),
                    new Claim(ClaimTypes.Name, usuario.Nome),
                    new Claim(ClaimTypes.Email, usuario.Email),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static JwtSecurityToken Decode(string token)
        {
            return new JwtSecurityTokenHandler().ReadJwtToken(token);
        }

        public static bool Check(string token)
        {
            return new JwtSecurityTokenHandler().CanReadToken(token);
        }
    }
}
