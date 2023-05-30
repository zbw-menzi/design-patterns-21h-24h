using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem
{
    internal class CCSystemProxy : Transaction
    {
        private CreditCardSystem system;

        CCSystemProxy(CreditCardSystem system)
        {
            this.system = system;
        }

        public override float BookMoneyFromAccount(float amount)
        {
            if (system.Account.Money > amount)
                {
                    return system.BookMoneyFromAccount(amount);
                }
                else
                {
                    throw new ArgumentException("Your Cash Amount is below the" +
                                                " wanted amount to draw from your account");
                }

            return system.Account.Money;
        }

        public override float AddMoneyToAccount(float amount)
        {
            throw new NotImplementedException();
        }

        public override float GetMoneyAmount()
        {
            return system.Account.Money;
        }
    }
}
