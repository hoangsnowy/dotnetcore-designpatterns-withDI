using Autofac;
using DotNetCore.DecoratorPatterns.Services;

namespace DotNetCore.DecoratorPatterns.AutofacModules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            builder.RegisterType<ShopppingCart>().As<IShopppingCart>();
            builder.RegisterDecorator<DiscountShoppingCartDecorator, IShopppingCart>();
            builder.RegisterDecorator<AuthencicationShoppingCartDecorator, IShopppingCart>();
        }
    }
}
