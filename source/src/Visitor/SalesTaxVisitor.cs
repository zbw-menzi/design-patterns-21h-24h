namespace Zbw.DesignPatterns.Visitor;

public class SalesTaxVisitor : IProductVisitor
{
    public void Visit(Book book)
    {
        Console.WriteLine($"Sales tax for the book with ISBN: {book.IsbnNumber} is: {book.Price * 0.1m}");
    }

    public void Visit(DVD dvd)
    {
        Console.WriteLine($"Sales tax for the DVD titled: {dvd.Title} is: {dvd.Price * 0.2m}");
    }
}