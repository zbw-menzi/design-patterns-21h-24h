namespace design_patterns.Strategy;

internal class AbsoluteDiscountPricingStrategy : ISalePricingStrategy
{
    private readonly decimal _percentage;
    private readonly decimal _threshold;
    private readonly decimal _discount;

    public AbsoluteDiscountPricingStrategy(decimal threshold, decimal discount)
    {
        _threshold = threshold;
        _discount = discount;
    }

    public decimal GetTotal(Sale sale)
    {
        if (sale.Amount >= _threshold)
        {
            return sale.Amount - _discount;
        }

        return sale.Amount;
    }
}