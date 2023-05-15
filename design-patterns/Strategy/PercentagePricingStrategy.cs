namespace design_patterns.Strategy;

internal class PercentagePricingStrategy : ISalePricingStrategy
{
    private readonly decimal _percentage;

    public PercentagePricingStrategy(decimal percentage)
    {
        _percentage = percentage;
    }

    public decimal GetTotal(Sale sale)
    {
        return sale.Amount - sale.Amount * (_percentage / 100m);
    }
}
