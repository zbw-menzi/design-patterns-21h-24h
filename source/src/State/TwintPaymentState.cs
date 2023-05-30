namespace Zbw.DesignPatterns.State
{
    public class TwintPaymentState : IPaymentState
    {
        public string Pay(decimal amount)
        {
            return $"Twintzahlung in Höhe von {amount} erfolgreich";
        }

        public string Undo()
        {
            return "Twintzahlung rückgängig gemacht";
        }

        public string Cancel()
        {
            return "Twintzahlung abgebrochen";
        }
    }
}
