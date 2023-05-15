namespace design_patterns.Strategy;

public interface ISalePricingStrategy
{
    decimal GetTotal(Sale sale);
}
