using NUnit.Framework;
using FluentAssertions;
using Zbw.DesignPatterns.Mediator;

namespace Zbw.DesignPatterns.Tests.Mediator
{
    public class MediatorUpdateStorageTest
    {
        [Fact]
        public void UpdateStorageWhenSellItem()
        {
            var mediator = new DesignPatterns.Mediator.Mediator();

            mediator.Store1.SellItem();

            mediator.Store2.StorageUpdated.Should().BeTrue();
            mediator.Store3.StorageUpdated.Should().BeTrue();
            mediator.Store4.StorageUpdated.Should().BeTrue();
        }
    }
}
