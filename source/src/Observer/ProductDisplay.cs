namespace Zbw.DesignPatterns.Observer
{
    internal class ProductDisplay : IObserver
    {
        public ProductDisplay(IStore store)
        {
            ProductSalePrice = store.GetProductSalePrice();
        }

        public decimal ProductSalePrice { get; private set; }

        public void Update(IStore store)
        {
            ProductSalePrice = store.GetProductSalePrice();
        }
    }
}
