using FluentAssertions;
using Zbw.DesignPatterns.Memento;

namespace Zbw.DesignPatterns.Tests.Memento {
  public class MementoTests {

    [Fact]
    public void RestoreSalesPrice_WhenSalesPriceChanged_ThenReturnOldSalesPrice() {
      // Arrange
      var amount = 12.50m;
      var validFrom = new DateTime(2023, 1, 1);
      var validTo = new DateTime(2023, 12, 31);
      var salesPrice = new SalesPrice(amount, validFrom, validTo);

      // Act
      var memory = new SalesPriceMemory();
      memory.SalesPriceMemento = salesPrice.SaveMemento();

      salesPrice = new SalesPrice(7.90m, new DateTime(2024, 1, 12), new DateTime(2024, 3, 31));

      salesPrice.RestoreMemento(memory.SalesPriceMemento);

      // Assert
      var expectedSalesPrice = new SalesPrice(amount, validFrom, validTo);
      salesPrice.Equals(expectedSalesPrice).Should().BeTrue();
    }

  }
}
