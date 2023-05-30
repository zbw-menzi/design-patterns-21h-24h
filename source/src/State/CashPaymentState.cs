namespace Zbw.DesignPatterns.State
{
    public class CashPaymentState : IPaymentState
    {
        public string Pay(decimal amount)
        {
            return $"Barzahlung in Höhe von {amount} erfolgreich";
        }

        public string Undo()
        {
            return "Barzahlung rückgängig gemacht";
        }

        public string Cancel()
        {
            return "Barzahlung abgebrochen";
        }
    }
}
