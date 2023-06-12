namespace Zbw.DesignPatterns.Visitor;

public class Book : IVisitable
{
    public decimal Price { get; set; }
    public string IsbnNumber { get; set; }

    public Book(decimal price, string isbn)
    {
        Price = price;
        IsbnNumber = isbn;
    }

    public void Accept(IProductVisitor visitor)
    {
        visitor.Visit(this);
    }
}