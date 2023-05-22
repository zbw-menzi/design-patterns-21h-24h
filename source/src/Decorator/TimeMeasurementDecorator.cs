namespace Zbw.DesignPatterns.Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Zbw.DesignPatterns.Strategy;

    public class TimeMeasurementDecorator : IPricingStrategy
    {
        private readonly IPricingStrategy _pricingStrategy;

        public TimeMeasurementDecorator(IPricingStrategy pricingStrategy)
        {
            _pricingStrategy = pricingStrategy;
        }

        public TimeSpan? ExecutionTime { get; private set; }

        public decimal GetTotal(Sale sale)
        {
            var swatch = Stopwatch.StartNew();
            try
            {
                return _pricingStrategy.GetTotal(sale);
            }
            finally
            {
                swatch.Stop();
                ExecutionTime = swatch.Elapsed;
            }
        }
    }
}
