namespace DotNetCore.DecoratorPatterns.Services
{
    public class DiscountShoppingCartDecorator : IShopppingCart
    {
        private readonly IShopppingCart _decoree;
        public DiscountShoppingCartDecorator(IShopppingCart decoree)
        {
            _decoree = decoree;
        }

        public string Order()
        {
            string discount = "discount";

            return $"{discount} {_decoree.Order()}";
        }
    }
}
