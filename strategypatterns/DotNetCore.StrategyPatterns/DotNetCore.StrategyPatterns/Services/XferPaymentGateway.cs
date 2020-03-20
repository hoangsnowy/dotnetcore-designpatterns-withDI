using DotNetCore.StrategyPatterns.Models;

namespace DotNetCore.StrategyPatterns.Services
{
    public class XferPaymentGateway : IPaymentGatewayStrategy
    {
        public PaymentType PaymentType => PaymentType.Xfer;

        public string Pay()
        {
            return "Xfer";
        }
    }
}
