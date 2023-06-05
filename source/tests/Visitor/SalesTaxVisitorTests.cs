using FluentAssertions;
using Zbw.DesignPatterns.Visitor;

namespace Zbw.DesignPatterns.Tests.Visitor;

public class SalesTaxVisitorTests
{
    [Fact]
    public void SalesTaxVisitor_Should_Print_SaleTaxes()
    {
        //Arrange
        Book book = new Book(22.30m, "128ED");
        DVD dvd = new DVD(18.20m, "Frickler");
        SalesTaxVisitor salesTaxVisitor = new SalesTaxVisitor();
        var writer = new StringWriter();
        Console.SetOut(writer);
        
        dvd.Accept(salesTaxVisitor);
        book.Accept(salesTaxVisitor);

        //Act
        var output = writer.GetStringBuilder().ToString().Trim();
        
        //Assert
        output.Should()
            .Be("Sales tax for the DVD titled: Frickler is: 3.640" +
                "\nSales tax for the book with ISBN: 128ED is: 2.230");
    }
}