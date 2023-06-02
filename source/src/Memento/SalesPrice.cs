namespace Zbw.DesignPatterns.Memento {
  public class SalesPrice {

    public SalesPrice(decimal amount, DateTime validFrom, DateTime validTo) {
      Amount = amount;
      ValidFrom = validFrom;
      ValidTo = validTo;
    }

    public SalesPriceMemento SaveMemento() {
      return new SalesPriceMemento(Amount, ValidFrom, ValidTo);
    }

    public void RestoreMemento(SalesPriceMemento memento) {
      Amount = memento.Amount;
      ValidFrom = memento.ValidFrom;
      ValidTo = memento.ValidTo;
    }

    public decimal Amount { get; private set; }

    public DateTime ValidFrom { get; private set; }

    public DateTime ValidTo { get; private set; }

    public override bool Equals(object? obj) {
      return Equals(obj as SalesPrice);
    }

    public bool Equals(SalesPrice other) {
      if (Object.ReferenceEquals(null, other)) {
        return false;
      }
      if (Object.ReferenceEquals(this, other)) {
        return true;
      }

      return Amount.Equals(other.Amount)
        && DateTime.Equals(ValidFrom, other.ValidFrom)
        && DateTime.Equals(ValidTo, other.ValidTo);
    }

    public override int GetHashCode() {
      return HashCode.Combine(Amount, ValidFrom, ValidTo);
    }
  }
}
