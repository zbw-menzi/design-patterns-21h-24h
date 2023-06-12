using Zbw.DesignPatterns.Observer;
using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Tests.Observer
{
    public class StoreTests
    {
        [Fact]
        public void StoreValueChaned_PriceChanged_DisplayGotUpdated()
        {
            // arrange
            ProductStore store = new ProductStore();
            ProductDisplay display = new ProductDisplay(store);
            
            store.Attach(display);
            decimal priceBevore = display.ProductSalePrice;

            // act
            store.ProductPrice = 33;

            // assert
            decimal priceAfter = display.ProductSalePrice;
            Assert.NotEqual(priceBevore, priceAfter);
        }

        [Fact]
        public void StoreValueChaned_PricingStrategyChanged_DisplayGotUpdated()
        {
            // arrange
            ProductStore store = new ProductStore();
            ProductDisplay display = new ProductDisplay(store);
            
            store.Attach(display);
            decimal priceBevore = display.ProductSalePrice;

            // act
            store.PricingStrategy = new PercentagePricingStrategy(20);

            // assert
            decimal priceAfter = display.ProductSalePrice;
            Assert.NotEqual(priceBevore, priceAfter);
        }
    }
}
