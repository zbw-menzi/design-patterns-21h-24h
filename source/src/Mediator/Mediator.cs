namespace Zbw.DesignPatterns.Mediator
{
    public class Mediator : IMediator
    {
        private Store1 store1;
        private Store2 store2;
        private Store3 store3;
        private Store4 store4;

        public void Notify(object sender)
        {
            if (sender.GetType() == store1.GetType())
            {
                store2.UpdateStorage();
                store3.UpdateStorage();
                store4.UpdateStorage();
            }
            else if (sender.GetType() == store2.GetType())
            {
                store1.UpdateStorage();
                store3.UpdateStorage();
                store4.UpdateStorage();
            }
            else if (sender.GetType() == store3.GetType())
            {
                store1.UpdateStorage();
                store2.UpdateStorage();
                store4.UpdateStorage();
            }
            else if (sender.GetType() == store4.GetType())
            {
                store1.UpdateStorage();
                store2.UpdateStorage();
                store3.UpdateStorage();
            }
            else
            {
                // ErrorHandling
            }
        }
    }
}
