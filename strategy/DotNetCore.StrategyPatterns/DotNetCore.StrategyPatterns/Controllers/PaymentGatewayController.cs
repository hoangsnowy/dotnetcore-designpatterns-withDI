using DotNetCore.StrategyPatterns.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.StrategyPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PaymentGatewayController : ControllerBase
    {
        private readonly IPaymentGatewayFactory _paymentGatewayFactory;
        public PaymentGatewayController(IPaymentGatewayFactory paymentGatewayFactory)
        {
            _paymentGatewayFactory = paymentGatewayFactory;
        }

        [Route("")]
        public IActionResult Ping()
        {
            return Ok();
        }

        [Route("paypal")]
        public string GetPaypal()
        {
            return _paymentGatewayFactory.Create(Models.PaymentType.Paypal).Pay();
        }

        [Route("stripe")]
        public string GetStripe()
        {
            return _paymentGatewayFactory.Create(Models.PaymentType.Stripe).Pay();
        }

        [Route("Xfer")]
        public string GetXfer()
        {
            return _paymentGatewayFactory.Create(Models.PaymentType.Xfer).Pay();
        }
    }
}