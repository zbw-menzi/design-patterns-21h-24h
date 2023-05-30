using FluentAssertions;
using Moq;
using Zbw.DesignPatterns.ChainOfResponsibility;
using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Tests.ChainOfResponsibility
{
    public class SaleApprovalServiceTests
    {
        [Theory]
        [InlineData(ManagerMood.Happy, true)]
        [InlineData(ManagerMood.Neutral, true)]
        [InlineData(ManagerMood.Grumpy, false)]
        public void TryApproveSale_WithManager_SaleApprovalStateCorrect(ManagerMood mood, bool shouldBeApproved)
        {
            var salePrice = 150m;
            var pricingMock = new Mock<IPricingStrategy>();
            pricingMock.Setup(m => m.GetTotal(It.IsAny<Sale>())).Returns(salePrice);

            var sut = new SaleApprovalService(new StoreManager(mood));
            var sale = new Sale(pricingMock.Object, salePrice);

            sut.TryApproveSale(sale);

            sale.IsApproved.Should().Be(shouldBeApproved);
        }

        [Theory]
        [InlineData(99, true)]
        [InlineData(100, false)]
        [InlineData(101, false)]
        public void TryApproveSale_WithThreshold_SaleApprovalStateCorrect(decimal salePrice, bool shouldBeApproved)
        {
            var pricingMock = new Mock<IPricingStrategy>();
            pricingMock.Setup(m => m.GetTotal(It.IsAny<Sale>())).Returns(salePrice);

            var sut = new SaleApprovalService(Mock.Of<IStoreManager>());
            var sale = new Sale(pricingMock.Object, salePrice);

            sut.TryApproveSale(sale);

            sale.IsApproved.Should().Be(shouldBeApproved);
        }

        [Fact]
        public void TryApproveSale_OverThreholdWithoutManager_DoesNotGetApproved()
        {
            var salePrice = 150;
            var storeManagerMock = new Mock<IStoreManager>();
            storeManagerMock.Setup(m => m.IsInOffice()).Returns(false);
            var pricingMock = new Mock<IPricingStrategy>();
            pricingMock.Setup(m => m.GetTotal(It.IsAny<Sale>())).Returns(salePrice);

            var sut = new SaleApprovalService(storeManagerMock.Object);
            var sale = new Sale(pricingMock.Object, salePrice);

            sut.TryApproveSale(sale);

            sale.IsApproved.Should().BeFalse();
        }

    }
}
