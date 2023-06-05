using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Bridge
{
    
        public class PurchaseOrder : Order
        {
            public PurchaseOrder(IPayment payment) : base(payment)
            {
            }
            public override void Checkout(decimal amount)
            {
                Payment.SubmitPayment(amount);
            }
        }
}
