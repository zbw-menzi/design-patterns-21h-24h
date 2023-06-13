using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zbw.DesignPatterns.Factory;
using Zbw.DesignPatterns.Strategy;
using ZbW.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Facade
{
    public class PricingStrategyFacade 
    {
        public readonly NullDiscountStrategy _nullDiscountStrategy;
        public readonly DoubleDiscountAfterLunchStrategy _doubleDiscountAfterLunchStrategy;
        public readonly AbsoluteDiscountOverThresholdStrategy _absoluteDiscountOverThresholdStrategy;
        public decimal Threshold { get; set; }
        public decimal AbsoluteDiscount { get; set; }

        public PricingStrategyFacade(decimal threshold, decimal absoluteDiscount)
        {
            Threshold = threshold;
            AbsoluteDiscount = absoluteDiscount;

            _nullDiscountStrategy = new NullDiscountStrategy();
            _doubleDiscountAfterLunchStrategy = new DoubleDiscountAfterLunchStrategy(new TimeSource(), 10m);
            _absoluteDiscountOverThresholdStrategy = new AbsoluteDiscountOverThresholdStrategy(Threshold, AbsoluteDiscount);
        }

        public decimal GetTotal(Sale sale, IPricingStrategy pricingStrategy)
        {
            if (IsSaleValid(sale) && IsPricingStrategyValid(pricingStrategy))
            {
                return pricingStrategy.GetTotal(sale);
            }
            return GetDefaultStrategy().GetTotal(sale);
        }


        private bool IsSaleValid(Sale sale) => sale != null;
        private bool IsPricingStrategyValid(IPricingStrategy pricingStrategy) => pricingStrategy != null;
        public IPricingStrategy GetDefaultStrategy() => _nullDiscountStrategy;
    }
}
