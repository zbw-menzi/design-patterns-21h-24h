using System.Security.Policy;
using FluentAssertions;
using Moq;
using Zbw.DesignPatterns.Adapter;
using Zbw.DesignPatterns.State;

namespace Zbw.DesignPatterns.Tests.State
{
    public class StatePatternTests
    {
        [Fact]
        public void ProcessTwintPaymentState()
        {
            // arrange
            var sut = new PoS(new TwintPaymentState());

            // act
            var result = sut.ProcessPayment(23);

            // assert
            result.Should().Be("Twintzahlung in Höhe von 23 erfolgreich");
        }

        [Fact]
        public void ProcessCashPaymentState()
        {
            // arrange
            var sut = new PoS(new CashPaymentState());

            // act
            var result = sut.ProcessPayment(23);

            // assert
            result.Should().Be("Barzahlung in Höhe von 23 erfolgreich");
        }

        [Fact]
        public void CancelTwintPaymentState()
        {
            // arrange
            var sut = new PoS(new TwintPaymentState());

            // act
            var result = sut.CancelPayment();

            // assert
            result.Should().Be("Twintzahlung abgebrochen");
        }

        [Fact]
        public void CancelCashPaymentState()
        {
            // arrange
            var sut = new PoS(new CashPaymentState());

            // act
            var result = sut.CancelPayment();

            // assert
            result.Should().Be("Barzahlung abgebrochen");
        }
    }
}
