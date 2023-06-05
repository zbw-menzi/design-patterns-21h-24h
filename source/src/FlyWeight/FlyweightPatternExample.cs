using System;
using System.Collections.Generic;

namespace FlyweightPatternExample
{
    // Flyweight-Schnittstelle
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    // Konkrete Flyweight-Klasse
    public class CreditCardPayment : IPaymentMethod
    {
        private string cardNumber;
        private string cardHolder;
        private DateTime expirationDate;

        public CreditCardPayment(string cardNumber, string cardHolder, DateTime expirationDate)
        {
            this.cardNumber = cardNumber;
            this.cardHolder = cardHolder;
            this.expirationDate = expirationDate;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:CHF} with card number {cardNumber}");
            // Führe den Zahlungsvorgang für Kreditkarte aus
        }
    }

    // Flyweight-Factory
    public class PaymentMethodFactory
    {
        private Dictionary<string, IPaymentMethod> paymentMethods = new Dictionary<string, IPaymentMethod>();

        public IPaymentMethod GetPaymentMethod(string cardNumber, string cardHolder, DateTime expirationDate)
        {
            string key = $"{cardNumber}-{cardHolder}-{expirationDate.ToString("yyyy-MM")}";

            if (!paymentMethods.ContainsKey(key))
            {
                paymentMethods[key] = new CreditCardPayment(cardNumber, cardHolder, expirationDate);
            }

            return paymentMethods[key];
        }
    }

    // Klientenklasse
    public class PaymentProcessor
    {
        private PaymentMethodFactory paymentMethodFactory;

        public PaymentProcessor(PaymentMethodFactory paymentMethodFactory)
        {
            this.paymentMethodFactory = paymentMethodFactory;
        }

        public void ProcessPayment(string cardNumber, string cardHolder, DateTime expirationDate, decimal amount)
        {
            IPaymentMethod paymentMethod = paymentMethodFactory.GetPaymentMethod(cardNumber, cardHolder, expirationDate);
            paymentMethod.ProcessPayment(amount);
        }
    }

}
