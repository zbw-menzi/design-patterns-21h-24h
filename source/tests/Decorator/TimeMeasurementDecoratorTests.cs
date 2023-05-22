namespace Zbw.DesignPatterns.Tests.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Zbw.DesignPatterns.Decorator;
    using Zbw.DesignPatterns.Strategy;

    public class TimeMeasurementDecoratorTests
    {
        [Fact]
        public void MeasureTime_WhenStrategyDecorated_ThenMeasuredTimeAvailable()
        {
            // Arrange
            var stragegy = new AbsoluteDiscountOverThresholdStrategy(100, 20);
            var decorator = new TimeMeasurementDecorator(stragegy);
            var sale = new Sale(decorator, 100);

            // Act
            _ = sale.GetTotal();

            // Assert
            decorator.ExecutionTime.Should().HaveValue();
            decorator.ExecutionTime.Should().BeGreaterThan(TimeSpan.Zero);
        }
    }
}
