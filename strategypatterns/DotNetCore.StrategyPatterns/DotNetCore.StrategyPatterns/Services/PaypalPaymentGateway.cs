using DotNetCore.StrategyPatterns.Models;

namespace DotNetCore.StrategyPatterns.Services
{
    public class PaypalPaymentGateway : IPaymentGatewayStrategy
    {
        public PaymentType PaymentType => PaymentType.Paypal;

        public string Pay()
        {
            return "Paypal";
        }
    }
}
