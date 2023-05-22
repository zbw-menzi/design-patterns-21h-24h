namespace Zbw.DesignPatterns.Composite
{
    using System.Collections.Generic;

    using Zbw.DesignPatterns.Strategy;

    public abstract class CompositePricingStrategy : IPricingStrategy
    {
        private readonly List<IPricingStrategy> _pricingStrategies;

        protected CompositePricingStrategy()
        {
            _pricingStrategies = new List<IPricingStrategy>();
        }

        public void Add(IPricingStrategy pricingStrategy)
        {

            _pricingStrategies.Add(pricingStrategy);
        }

        protected IReadOnlyList<IPricingStrategy> PricingStrategies => _pricingStrategies.AsReadOnly();

        public abstract decimal GetTotal(Sale sale);
    }
}
