using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiJwt.Models
{
    public class AddToken
    {
        public string TokenAdd()
        {
            var bytes = Encoding.UTF8.GetBytes("this is my custom Secret key for authentication");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(3), signingCredentials: credentials);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(token);
        }

        public string TokenAddAdmin()
        {
            var bytes = Encoding.UTF8.GetBytes("this is my custom Secret key for authentication");

            SymmetricSecurityKey key = new SymmetricSecurityKey(bytes);

            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,"Admin"),
                new Claim(ClaimTypes.Role,"Visitor")

            };

            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(issuer: "http://localhost", audience: "http://localhost", notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(3), signingCredentials: credentials,claims:claims);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(jwtSecurityToken);
        }
    }
}
