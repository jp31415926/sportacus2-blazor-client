using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestBlazorApp.Auth
{
    public class UserService
    {
        public Task<IEnumerable<Claim>> GetClaims(string UserId)
        {
            try
            {
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Name, UserId));
                claims.Add(new Claim(ClaimTypes.Role, "Users"));
                claims.Add(new Claim(ClaimTypes.Role, "Geek"));
                claims.Add(new Claim(ClaimTypes.Email, UserId + "@sportacus.com"));

                var claimsIdentity = new ClaimsIdentity(claims, "Sportacus");
                return Task.FromResult(claimsIdentity.Claims);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
