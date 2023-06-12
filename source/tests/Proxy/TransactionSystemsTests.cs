using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Zbw.DesignPatterns.Proxy.ExampleWithCreditCardSystem;

namespace Zbw.DesignPatterns.Tests.Proxy
{
    public class TransactionSystemsTests
    {
        [Fact]
        public void CCSystem_Book300MoneyFrom500Account_Expecting200()
        {
            // arrange
            Transaction ccSystem = new CreditCardSystem(new Account(500));

            // act
            var result = ccSystem.BookMoneyFromAccount(300);

            // assert
            result.Should().Be(200);
        }

        [Fact]
        public void CCSystem_Add300MoneyTo500Account_Expecting800()
        {
            // arrange
            Transaction ccSystem = new CreditCardSystem(new Account(500));

            // act
            var result = ccSystem.AddMoneyToAccount(300);

            // assert
            result.Should().Be(800);
        }


        [Fact]
        public void CCSystemProxy_Book300MoneyFrom200Account_ExpectingException()
        {
            // arrange
            CreditCardSystem ccSystem = new CreditCardSystem(new Account(200));

            Transaction ccsProxy = new CCSystemProxy(ccSystem);

            // act & assert
             Assert.Throws<ArgumentException>(() => ccsProxy.BookMoneyFromAccount(300));

            // assert
            //result.Should().Be(new ArgumentException("Your Cash Amount is below the" +
            //                                         " wanted amount to draw from your account"));
        }
    }
}
