using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Bridge
{

        public class TwintPayment : IPayment
        {
            private IPaymentGateway _mPaymentGateway;

            public TwintPayment(IPaymentGateway paymentGateway)
            {
                _mPaymentGateway = paymentGateway;
            }
            public void SubmitPayment(decimal amount)
            {
                _mPaymentGateway.ProcessPayment(amount, this);
            }
        }
    

}
