using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.ChainOfResponsibility
{
    internal class SaleApprovalService
    {
        private readonly IStoreManager _manager;

        public SaleApprovalService(IStoreManager manager)
        {
            _manager = manager;
        }

        public bool TryApproveSale(Sale sale)
        {
            var approvalHandler = BuildApprovalChain();

            approvalHandler.HandleSale(sale);

            return sale.IsApproved;
        }

        private ThresholdSaleApprovalHandler BuildApprovalChain()
        {
            var abortingHandler = new AbortingSaleApprovalHandler();
            var managerHandler = new ManagerSaleApprovalHandler(abortingHandler, this._manager);
            return new ThresholdSaleApprovalHandler(managerHandler);
        }
    }
}
