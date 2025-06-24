using BitzArt.Blazor.Auth;
using BitzArt.Blazor.Auth.Server;
using BuildStart.BitzArt.Blazor.Auth.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildStart.BitzArt.Blazor.Auth.Server.Services
{
    internal class BuildStartAuthenticationService : AuthenticationService<LoginModel, UserRegistrationModel>
    {
        public override Task<AuthenticationResult> RefreshJwtPairAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<AuthenticationResult> SignInAsync(LoginModel signInPayload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<AuthenticationResult> SignUpAsync(UserRegistrationModel signUpPayload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
