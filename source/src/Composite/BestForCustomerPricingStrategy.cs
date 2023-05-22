namespace Zbw.DesignPatterns.Composite
{
    using System.Linq;

    using Zbw.DesignPatterns.Strategy;

    public class BestForCustomerPricingStrategy : CompositePricingStrategy
    {
        public override decimal GetTotal(Sale sale)
        {
            return PricingStrategies.Min(x => x.GetTotal(sale));
        }
    }
}
