namespace Zbw.DesignPatterns.Visitor;

public interface IVisitable
{
    void Accept(IProductVisitor visitor);
}