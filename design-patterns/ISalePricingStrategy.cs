namespace design_patterns;

public interface ISalePricingStrategy
{
    decimal GetTotal(Sale sale);
}
