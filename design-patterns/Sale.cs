namespace design_patterns;

public class Sale
{
    private readonly ISalePricingStrategy _pricingStrategy;
    private readonly decimal _amount;

    public Sale(ISalePricingStrategy pricingStrategy, decimal amount)
    {
        _pricingStrategy = pricingStrategy;
        _amount = amount;
    }

    public decimal GetTotal()
    {
        return _pricingStrategy.GetTotal(this);
    }
}
