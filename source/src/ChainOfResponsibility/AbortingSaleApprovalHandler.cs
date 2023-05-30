using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal class AbortingSaleApprovalHandler : ISaleApprovalHandler
{
    public void HandleSale(Sale sale)
    {
    }
}