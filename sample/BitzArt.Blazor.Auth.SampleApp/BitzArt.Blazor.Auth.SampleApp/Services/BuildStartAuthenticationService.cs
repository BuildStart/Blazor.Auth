using BitzArt.Blazor.Auth.Server;

namespace BitzArt.Blazor.Auth.SampleApp.Services
{
    public class BuildStartAuthenticationService : AuthenticationService<SignInPayload, SignUpPayload>
    {
        public override Task<AuthenticationResult> RefreshJwtPairAsync(string refreshToken, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<AuthenticationResult> SignInAsync(SignInPayload signInPayload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<AuthenticationResult> SignUpAsync(SignUpPayload signUpPayload, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
