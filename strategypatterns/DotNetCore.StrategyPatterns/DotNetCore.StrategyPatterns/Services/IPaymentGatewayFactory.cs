using DotNetCore.StrategyPatterns.Models;

namespace DotNetCore.StrategyPatterns.Services
{
    public interface IPaymentGatewayFactory
    {
        IPaymentGatewayStrategy Create(PaymentType paymentType);
    }
}
