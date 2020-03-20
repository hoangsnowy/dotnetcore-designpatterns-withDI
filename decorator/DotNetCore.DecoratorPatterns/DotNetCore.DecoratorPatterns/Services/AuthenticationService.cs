namespace DotNetCore.DecoratorPatterns.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public bool Authenticate()
        {
            return true;
        }
    }
}
