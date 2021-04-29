using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Auth
{
    public class SecurityService
    {
        public Task<bool> ValidatePassword(string userId, string password)
        {
            return Task.FromResult(true);
        }
    }
}
