using System;

namespace DotNetCore.DecoratorPatterns.Services
{
    public class AuthencicationShoppingCartDecorator : IShopppingCart
    {
        private readonly IShopppingCart _decoree;
        private readonly IAuthenticationService _authenticationService;
        public AuthencicationShoppingCartDecorator(IShopppingCart decoree, IAuthenticationService authenticationService)
        {
            _decoree = decoree;
            _authenticationService = authenticationService;
        }

        public string Order()
        {
            if (!_authenticationService.Authenticate())
            {
                return "Unauthenticate";
            }

            return _decoree.Order();
        }
    }
}
