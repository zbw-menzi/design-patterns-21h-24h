namespace Zbw.DesignPatterns.State
{
    public class UnpaidOrderState : OrderState
    {
        public UnpaidOrderState(Order order) : base(order)
        {
        }
    }
}
