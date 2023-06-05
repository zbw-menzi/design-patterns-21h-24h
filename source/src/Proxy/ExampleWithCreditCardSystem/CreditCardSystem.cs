using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem
{
    public class CreditCardSystem : Transaction
    {
        private Account acc;
        public Account Account => acc;

        public CreditCardSystem(Account acc)
        {
            this.acc = acc;
        }

        public override float BookMoneyFromAccount(float amount)
        {
            return this.acc.DecreaseMoney(amount);
        }

        public override float AddMoneyToAccount(float amount)
        {
            return this.acc.IncreaseMoney(amount);
        }

        public override float GetMoneyAmount()
        {
            return acc.Money;
        }
    }
}
