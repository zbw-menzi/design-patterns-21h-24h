namespace Zbw.DesignPatterns.Tests.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FluentAssertions;

    using Zbw.DesignPatterns.Factory;
    using Zbw.DesignPatterns.Strategy;

    public class PricingStrategyFactoryTests
    {
        [Fact]
        public void Create_WhenAbsolute_ThenImplementationAlsoAbsolute()
        {
            Environment.SetEnvironmentVariable("PRICING_STRATEGY", "Absolute");
            Environment.SetEnvironmentVariable("PRICING_STRATEGY_ARGS", "100,20");

            var strategy = PricingStrategyFactory.Create();

            strategy.Should().BeOfType<AbsoluteDiscountOverThresholdStrategy>();
        }
    }
}
