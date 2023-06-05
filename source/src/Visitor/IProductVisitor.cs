namespace Zbw.DesignPatterns.Visitor;

public interface IProductVisitor
{
    void Visit(Book book);
    void Visit(DVD dvd);
}