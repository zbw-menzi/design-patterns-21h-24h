using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(IStore store);
    }
}
