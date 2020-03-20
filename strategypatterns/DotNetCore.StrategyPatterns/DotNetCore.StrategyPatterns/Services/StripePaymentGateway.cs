using DotNetCore.StrategyPatterns.Models;

namespace DotNetCore.StrategyPatterns.Services
{
    public class StripePaymentGateway : IPaymentGatewayStrategy
    {
        public PaymentType PaymentType => PaymentType.Stripe;

        public string Pay()
        {
            return "Stripe";
        }
    }
}
