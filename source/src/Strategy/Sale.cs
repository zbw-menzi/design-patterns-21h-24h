namespace Zbw.DesignPatterns.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sale
    {
        private readonly IPricingStrategy _pricingStrategy;
        private readonly decimal _amount;
        public bool IsApproved { get; private set; }

        public Sale(IPricingStrategy pricingStrategy, decimal amount)
        {
            ArgumentNullException.ThrowIfNull(pricingStrategy);

            _pricingStrategy = pricingStrategy;
            _amount = amount;
        }

        public decimal Amount => _amount;

        public decimal GetTotal()
        {
            return _pricingStrategy.GetTotal(this);
        }

        public void Approve()
        {
            this.IsApproved = true;
        }
    }
}
