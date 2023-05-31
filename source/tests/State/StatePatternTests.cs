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
        public void CreateOrder()
        {
            // arrange
            var sut = new PoS();

            // act
            sut.CreateOrder(1, 230);

            // assert
            sut.Order.State.Should().BeOfType(typeof(UnpaidOrderState));
        }

        [Fact]
        public void ProcessOrder()
        {
            // arrange
            var sut = new PoS();

            // act
            sut.CreateOrder(1, 230);
            sut.Process();

            // assert
            sut.Order.State.Should().BeOfType(typeof(ProcessOrderState));
        }

        [Fact]
        public void CancelOrder()
        {
            // arrange
            var sut = new PoS();

            // act
            sut.CreateOrder(1, 230);
            sut.Cancel();

            // assert
            sut.Order.State.Should().BeOfType(typeof(CancelOrderState));
        }

        [Fact]
        public void ShipOrder()
        {
            // arrange
            var sut = new PoS();

            // act
            sut.CreateOrder(1, 230);
            sut.Ship();

            // assert
            sut.Order.State.Should().BeOfType(typeof(ShipOrderState));
        }
    }
}
