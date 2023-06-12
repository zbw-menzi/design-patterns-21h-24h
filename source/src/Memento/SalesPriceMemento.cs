namespace Zbw.DesignPatterns.Memento {
  public class SalesPriceMemento {

    public SalesPriceMemento(decimal amount, DateTime validFrom, DateTime validTo) {
      Amount = amount;
      ValidFrom = validFrom;
      ValidTo = validTo;
    }

    public decimal Amount { get; private set; }
    public DateTime ValidFrom { get; private set; }
 
    public DateTime ValidTo { get; private set; }

  }
}
