namespace Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem;

internal class Account
{
    private float money { get; set; }

    private bool IsAccountBlocked { get;}

    public float Money
    {
        get => money;
        set => money -= value;
    }


    public Account(float money, bool isAccountBlocked)
    {
        this.Money = money;
        this.IsAccountBlocked = isAccountBlocked;
    }

    public float IncreaseMoney(float money)
    {
        return this.Money += money;
    }

    public float DecreaseMoney(float money)
    {
        return this.Money -= money;
    }
}