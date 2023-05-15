namespace design_pattern.Tests
{
    using design_patterns;

    using FluentAssertions;

    public class SaleTests
    {
        [Fact]
        public void GetTotal_WhenPercentageDiscountOf10_ThenReturn90()
        {
            // Arrange
            var strategy = new PercentagePricingStrategy(10m);
            var sale = new Sale(strategy, 100m);

            // Act + Assert
            sale.GetTotal().Should().Be(90);
        }
    }
}