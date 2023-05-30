namespace Zbw.DesignPatterns.State
{
    internal class PoS
    {
        private IPaymentState _state;

        public PoS(IPaymentState state)
        {
            _state = state;
        }

        public string ProcessPayment(decimal amount)
        {
            return _state.Pay(amount);
        }

        public string CancelPayment()
        {
            return _state.Cancel();
        }
    }
}
