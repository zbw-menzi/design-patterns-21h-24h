using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal class ManagerSaleApprovalHandler : SaleApprovalHandlerBase
{
    private readonly IStoreManager _manager;

    public ManagerSaleApprovalHandler(ISaleApprovalHandler nextHandler, IStoreManager manager) 
        : base(nextHandler)
    {
        _manager = manager;
    }

    public override void HandleSale(Sale sale)
    {
        if (_manager.IsInOffice() && _manager.ApprovesTheSale()) 
            sale.Approve();
        else
            NextHandler.HandleSale(sale);
    }
}