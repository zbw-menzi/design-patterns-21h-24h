using System.Net.NetworkInformation;

namespace Zbw.DesignPatterns.State
{
    public abstract class OrderState
    {
        protected Order Order { get; set; }
        protected OrderState(Order order)
        {
            Order = order;
        }
        
        public OrderState NewState(string input, Order order)
        {
            if (input == "process")
            {
                return new ProcessOrderState(order);
            }
            if (input == "cancel")
            {
                return new CancelOrderState(order);
            }
            if (input == "ship")
            {
                return new ShipOrderState(order);
            }
            else
            {
                return new UnpaidOrderState(order);
            }
        }
    }
}

