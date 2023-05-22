namespace Zbw.DesignPatterns.Tests.Composite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Zbw.DesignPatterns.Composite;
    using Zbw.DesignPatterns.Strategy;

    public class CompositePricingStrategyTests
    {
        [Fact]
        public void GetTotal_ReturnBestForCustomerPricingStrategy()
        {
            // Arrange
            var strategy1 = new PercentagePricingStrategy(10);
            var strategy2 = new AbsoluteDiscountOverThresholdStrategy(100, 20);

            var strategy = new BestForCustomerPricingStrategy();
            strategy.Add(strategy1);
            strategy.Add(strategy2);

            var sale = new Sale(strategy, 100);
            
            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(80);
        }

        [Fact]
        public void GetTotal_ReturnBestForStorePricingStrategy()
        {
            // Arrange
            var strategy1 = new PercentagePricingStrategy(10);
            var strategy2 = new AbsoluteDiscountOverThresholdStrategy(100, 20);

            var strategy = new BestForStorePricingStrategy();
            strategy.Add(strategy1);
            strategy.Add(strategy2);

            var sale = new Sale(strategy, 100);

            // Act
            var result = sale.GetTotal();

            // Assert
            result.Should().Be(90);
        }
    }
}
