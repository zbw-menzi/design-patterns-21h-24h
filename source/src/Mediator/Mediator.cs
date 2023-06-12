namespace Zbw.DesignPatterns.Mediator
{
    public class Mediator : IMediator
    {
        public Store1 Store1 { get; set; }
        public Store2 Store2 { get; set; }
        public Store3 Store3 { get; set; }
        public Store4 Store4 { get; set; }

        public Mediator()
        {
            Store1 = new Store1(this);
            Store2 = new Store2(this);
            Store3 = new Store3(this);
            Store4 = new Store4(this);
        }

        public void Notify(object sender)
        {
            if (sender.GetType() == Store1.GetType())
            {
                Store2.UpdateStorage();
                Store3.UpdateStorage();
                Store4.UpdateStorage();
            }
            else if (sender.GetType() == Store2.GetType())
            {
                Store1.UpdateStorage();
                Store3.UpdateStorage();
                Store4.UpdateStorage();
            }
            else if (sender.GetType() == Store3.GetType())
            {
                Store1.UpdateStorage();
                Store2.UpdateStorage();
                Store4.UpdateStorage();
            }
            else if (sender.GetType() == Store4.GetType())
            {
                Store1.UpdateStorage();
                Store2.UpdateStorage();
                Store3.UpdateStorage();
            }
            else
            {
                // ErrorHandling
            }
        }
    }
}
