namespace Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem;

public class Account
{
    private float money { get; set; }

    public float Money
    {
        get => money;
        set => money = value;
    }

    public Account(float money)
    {
        this.Money = money;
    }

    public float IncreaseMoney(float money)
    {
        return this.Money += money;
    }

    public float DecreaseMoney(float money)
    {
        return this.Money = this.Money - money;
    }
}