namespace Zbw.DesignPatterns.State
{
    internal interface IPaymentState
    {
        string Pay(decimal amount);
        string Undo();
        string Cancel();
    }
}
