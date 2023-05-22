namespace Zbw.DesignPatterns.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    using Zbw.DesignPatterns.Strategy;

    using ZbW.DesignPatterns.Strategy;

    public class PricingStrategyFactory
    {
        public static IPricingStrategy Create()
        {
            var pricingStrategy = Environment.GetEnvironmentVariable("PRICING_STRATEGY");
            var pricingStrategyArgs = Environment.GetEnvironmentVariable("PRICING_STRATEGY_ARGS");

            var strategies = typeof(IPricingStrategy).Assembly.GetTypes()
                .Where(x => typeof(IPricingStrategy).IsAssignableFrom(x))
                .Where(x => !x.IsInterface)
                .Where(x => !x.IsAbstract)
                .ToList();

            Type strategyType = strategies.SingleOrDefault(x => x.Name.StartsWith(pricingStrategy));
            if (strategyType == null)
            {
                return new NullDiscountStrategy();
            }

            var providedArgs = pricingStrategyArgs.Split(",");
            var ctor = strategyType.GetConstructors()[0];
            var ctorParameters = ctor.GetParameters();

            if (providedArgs.Length == ctorParameters.Length)
            {
                var covertedArgs = providedArgs.Select((arg, index) => Convert.ChangeType(arg, ctorParameters[index].ParameterType)).ToArray();
                var strategy = Activator.CreateInstance(strategyType, covertedArgs);
                return (IPricingStrategy)strategy;
            }

            return new NullDiscountStrategy();

        }
    }
}
