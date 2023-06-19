using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Bridge
{
         public abstract class Order
        {
            protected IPayment Payment { get; }
            public Order(IPayment payment)
            {
                Payment = payment;
            }
            public abstract void Checkout(decimal amount);
        }
    

}
