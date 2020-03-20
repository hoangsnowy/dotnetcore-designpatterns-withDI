using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.DecoratorPatterns.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.DecoratorPatterns.Controllers
{
    [Route("api/shopppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShopppingCart _shopppingCart;
        public ShoppingCartController(IShopppingCart shopppingCart)
        {
            _shopppingCart = shopppingCart;
        }

        [Route("order")]
        public string Order()
        {
            return _shopppingCart.Order();
        }
    }
}