using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility;

internal class ThresholdSaleApprovalHandler : SaleApprovalHandlerBase
{
    public ThresholdSaleApprovalHandler(ISaleApprovalHandler nextHandler) 
        : base(nextHandler)
    {
    }

    public override void HandleSale(Sale sale)
    {
        if (sale.GetTotal() < 100)
            sale.Approve();
        else
            this.NextHandler.HandleSale(sale);
    }
}