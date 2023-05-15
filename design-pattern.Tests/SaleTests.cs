namespace design_pattern.Tests
{
    using design_patterns;

    using FluentAssertions;

    using Moq;

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

        [Theory]
        [InlineData(99, 100, 99)]
        [InlineData(100, 100, 90)]
        [InlineData(101, 100, 91)]
        public void GetTotal_WhenThreshholdMet_Then10Discount(
            decimal amount,
            decimal threshold,
            decimal expected)
        {
            // Arrange
            var strategy = new AbsoluteDiscountPricingStrategy(threshold, 10m);
            var sale = new Sale(strategy, amount);

            // Act + Assert
            sale.GetTotal().Should().Be(expected);
        }

        [Fact]
        public void GetTotal_WhenBefore12_Then1TimesDiscount()
        {
            // Arrange
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(x => x.Now).Returns(new DateTime(2023, 5, 15, 11, 59, 59));
            var strategy = new DiscountByTimeOfDayStrategy(10m, dateTimeProvider.Object);
            var sale = new Sale(strategy, 100m);

            // Act + Assert
            sale.GetTotal().Should().Be(90);
        }

        [Fact]
        public void GetTotal_WhenAfter12_Then1TimesDiscount()
        {
            // Arrange
            var dateTimeProvider = new Mock<IDateTimeProvider>();
            dateTimeProvider.Setup(x => x.Now).Returns(new DateTime(2023, 5, 15, 12, 01, 01));
            var strategy = new DiscountByTimeOfDayStrategy(10m, dateTimeProvider.Object);
            var sale = new Sale(strategy, 100m);

            // Act + Assert
            sale.GetTotal().Should().Be(80);
        }
    }
}