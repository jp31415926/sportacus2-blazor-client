using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TestBlazorApp.Auth
{
    public class SportacusAuthenticationStateProvider: AuthenticationStateProvider
    {
        private string _userId;
        private string _password;

        public void LoadUser(string UserId, string Password)
        {
            _userId = UserId;
            _password = Password;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var securityService = new SecurityService();

            var userService = new UserService();

            var validPassword = await securityService.ValidatePassword(_userId, _password);

            var authenticated = validPassword == true ? true : false;


            var identity = authenticated
                ? new ClaimsIdentity(await userService.GetClaims(_userId), "AuthCheck")
                : new ClaimsIdentity();

            var result = new AuthenticationState(new ClaimsPrincipal(identity));

            return result;
        }
    }
}
