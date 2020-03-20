using DotNetCore.StrategyPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCore.StrategyPatterns.Services
{
    public class PaymentGatewayFactory : IPaymentGatewayFactory
    {
        private readonly IEnumerable<IPaymentGatewayStrategy> _availablePaymentGateways;
        public PaymentGatewayFactory(IEnumerable<IPaymentGatewayStrategy> paymentGateways)
        {
            _availablePaymentGateways = paymentGateways;
        }

        public IPaymentGatewayStrategy Create(PaymentType paymentType)
        {
            IPaymentGatewayStrategy paymentGateway = _availablePaymentGateways.FirstOrDefault(x => x.PaymentType == paymentType);

            if (paymentGateway == null)
            {
                throw new InvalidOperationException($"No supported strategy found for payment method '{paymentType}'.");
            }

            return paymentGateway;
        }
    }
}
