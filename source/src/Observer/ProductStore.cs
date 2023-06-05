using Zbw.DesignPatterns.Strategy;
using ZbW.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Observer
{
    internal class ProductStore : Store
    {
        private IPricingStrategy _pricingStrategy = new NullDiscountStrategy();
        private decimal _productPrice = 100;


        public IPricingStrategy PricingStrategy
        {
            get { return _pricingStrategy; }
            set
            {
                _pricingStrategy = value;
                Notify();
            }
        }

        public decimal ProductPrice
        {
            get { return _productPrice; }
            set
            {
                _productPrice = value;
                Notify();
            }
        }

        public override decimal GetProductSalePrice()
        {
            var sale = new Sale(_pricingStrategy, ProductPrice);
            return sale.GetTotal();
        }
    }
}
