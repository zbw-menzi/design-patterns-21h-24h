using Zbw.DesignPatterns.Facade;
using Zbw.DesignPatterns.Strategy;
using ZbW.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Tests.Facade
{
    public class PricingStrategyFacadeTests
    {
        [Fact]
        public void GetTotal_WithDefaultPricingStrategy_ReturnsDefaultTotal()
        {
            // Arrange
            decimal threshold = 50m;
            decimal absoluteDiscount = 10m;
            PricingStrategyFacade facade = new PricingStrategyFacade(threshold, absoluteDiscount);

            Sale sale = new Sale(facade.GetDefaultStrategy(), 100m);
            decimal expectedTotal = 100m;

            // Act
            decimal actualTotal = facade.GetTotal(sale, facade.GetDefaultStrategy());

            // Assert
            Assert.Equal(expectedTotal, actualTotal);
        }

        [Fact]
        public void GetTotal_WithAbsoluteDiscountOverThresholdStrategy_ReturnsCorrectTotal()
        {
            // Arrange
            decimal threshold = 50m;
            decimal absoluteDiscount = 10m;
            PricingStrategyFacade facade = new PricingStrategyFacade(threshold, absoluteDiscount);

            Sale sale = new Sale(new AbsoluteDiscountOverThresholdStrategy(threshold, absoluteDiscount), 60m);
            decimal expectedTotal = 50m; 

            // Act
            decimal actualTotal = facade.GetTotal(sale, facade._absoluteDiscountOverThresholdStrategy);

            // Assert
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}

