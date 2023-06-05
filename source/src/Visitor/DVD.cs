namespace Zbw.DesignPatterns.Visitor;

public class DVD : IVisitable
{
    public decimal Price { get; set; }
    public string Title { get; set; }

    public DVD(decimal price, string title)
    {
        Price = price;
        Title = title;
    }

    public void Accept(IProductVisitor visitor)
    {
        visitor.Visit(this);
    }
}