using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem
{
    public abstract class Transaction
    {
        public abstract float BookMoneyFromAccount(float amount);

        public abstract float AddMoneyToAccount(float amount);

        public abstract float GetMoneyAmount();
    }
}
