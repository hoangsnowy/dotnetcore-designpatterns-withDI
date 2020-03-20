using DotNetCore.StrategyPatterns.Models;

namespace DotNetCore.StrategyPatterns.Services
{
    public interface IPaymentGatewayStrategy
    {
        PaymentType PaymentType { get; }
        string Pay();
    }
}
