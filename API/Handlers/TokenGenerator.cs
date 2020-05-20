using API.ViewModels;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class TokenGenerator
    {
        public string Generator(AccountVM accountVM)
        {
            string securityKey = "this_is_security_key_longest_i_have_ever_been_written_before";

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);

            var claims = new List<Claim>();
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim("name", accountVM.Name));
            claims.Add(new Claim("email", accountVM.Email));
            claims.Add(new Claim("role", accountVM.Role));

            var token = new JwtSecurityToken(
                issuer: "www.brmclient.azurewebsites.net",
                audience: "www.brmclient.azurewebsites.net",
                claims: claims,
                expires: DateTime.Now.AddMinutes(2),
                signingCredentials: signingCredentials);

            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt_token;
        }
    }
}
