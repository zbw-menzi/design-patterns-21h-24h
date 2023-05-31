namespace Zbw.DesignPatterns.State
{
    public class CancelOrderState : OrderState
    {
        public CancelOrderState(Order order) : base(order)
        {
        }
    }
}
