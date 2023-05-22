namespace Zbw.DesignPatterns.Composite
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Zbw.DesignPatterns.Strategy;

    public class BestForStorePricingStrategy : CompositePricingStrategy
    {
        public override decimal GetTotal(Sale sale)
        {
            return PricingStrategies.Max(x => x.GetTotal(sale));
        }
    }
}
