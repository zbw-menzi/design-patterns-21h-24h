using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal abstract class SaleApprovalHandlerBase : ISaleApprovalHandler
{
    protected readonly ISaleApprovalHandler NextHandler;

    protected SaleApprovalHandlerBase(ISaleApprovalHandler nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract void HandleSale(Sale sale);
}