using Commons.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Commons.TokenGeneration
{
    public class ClsJwtSecurityToken
    {
        public static TokenResponse GetToken(string email, IList<Claim> ltClaim, IConfiguration configuration)
        {
            var expiration = DateTime.UtcNow.AddYears(1);
            var claims = new List<Claim>{
                new Claim("email", email)
            };

            claims.AddRange(ltClaim);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["KeyJwt"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: creds);

            return new TokenResponse
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration,
            };
        }
    }
}
