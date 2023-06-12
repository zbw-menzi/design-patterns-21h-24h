using System;
using Xunit;

namespace FlyweightPatternExample.Tests
{
    public class PaymentProcessorTests
    {
        [Fact]
        public void ProcessPayment_CreditCardPayment_ProcessesPayment()
        {
            // Arrange
            PaymentMethodFactory paymentMethodFactory = new PaymentMethodFactory();
            PaymentProcessor paymentProcessor = new PaymentProcessor(paymentMethodFactory);
            string cardNumber = "1234567890123456";
            string cardHolder = "John Doe";
            DateTime expirationDate = new DateTime(2025, 12, 31);
            decimal amount = 100.50m;

            // Act
            paymentProcessor.ProcessPayment(cardNumber, cardHolder, expirationDate, amount);

            // Assert
            
        }
    }
}
