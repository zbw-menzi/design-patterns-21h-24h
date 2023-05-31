namespace Zbw.DesignPatterns.State
{
    internal class PoS
    {
        public Order Order { get; set; }

        public void CreateOrder(int id, decimal amount)
        {
            Order = new Order(id, amount);
        }

        public void Process()
        {
            Order.ChangeState("process");
        }

        public void Cancel()
        {
            Order.ChangeState("cancel");
        }

        public void Ship()
        {
            Order.ChangeState("ship");
        }
    }
}
