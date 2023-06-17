namespace Zbw.DesignPatterns.State
{
    public class Order
    {
        private OrderState _state;
        public decimal Amount { get; set; }
        public int Id { get; set; }

        public Order(int id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }

        public OrderState State
        {
            get => _state ?? new UnpaidOrderState(this);
            set => _state = value;
        }

        public void ChangeState(string input)
        {
            var tmp = State.NewState(input, this);
            State = tmp;
        }
    }
}
