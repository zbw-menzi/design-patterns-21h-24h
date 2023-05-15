namespace design_patterns;

public class Sale
{
    private readonly ISalePricingStrategy _pricingStrategy;

    public Sale(ISalePricingStrategy pricingStrategy, decimal amount)
    {
        _pricingStrategy = pricingStrategy;

        Amount = amount;
    }

    internal decimal Amount { get; }

    public decimal GetTotal()
    {
        return _pricingStrategy.GetTotal(this);
    }
}
