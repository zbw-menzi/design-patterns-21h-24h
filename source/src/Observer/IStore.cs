namespace Zbw.DesignPatterns.Observer
{
    public interface IStore
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        decimal GetProductSalePrice();
    }
}
