using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal interface ISaleApprovalHandler
{
    public void HandleSale(Sale sale);
}