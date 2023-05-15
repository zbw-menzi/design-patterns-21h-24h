namespace design_patterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class DiscountByTimeOfDayStrategy : ISalePricingStrategy
    {
        private readonly decimal _percentage;
        private readonly IDateTimeProvider _dateTimeProvider;

        public DiscountByTimeOfDayStrategy(decimal percentage, IDateTimeProvider dateTimeProvider)
        {
            _percentage = percentage;
            _dateTimeProvider = dateTimeProvider;
        }

        public decimal GetTotal(Sale sale)
        {
            if (_dateTimeProvider.Now.Hour < 12)
            {
                return sale.Amount - sale.Amount * (_percentage / 100m);
            }
            else
            {
                return sale.Amount - sale.Amount * (2 * _percentage / 100m);
            }
        }
    }
}
