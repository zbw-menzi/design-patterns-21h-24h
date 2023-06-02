using FluentAssertions;

    using Moq;

    using Xunit;

    using Zbw.DesignPatterns.Adapter;
using Zbw.DesignPatterns.Command;
using Zbw.DesignPatterns.Strategy;

namespace Zbw.DesignPatterns.Tests.Command
{
    public class CommandPatternTests
    {

        //Command Pattern Example:
        //In a Restaurant
        //the Customer is the Client.
        //Order i.e. what kind of food the customer wants is the Command.
        //The Waiter is the Invoker. The Waiter does not know how to cook the food. So, the Waiter just passes the request to the Receiver (cook)
        //the Cook who will prepare the food and give the food back to the Waiter, and the Waiter gave it back to the customer.

        [Fact]
        public void InvokeGetTotal_CalculateSaleAmountMinusDiscount_ShouldBe90()
        {
            //Arrange

            //Create receiver object
            IPricingStrategy strategy = new PercentagePricingStrategy(10m);
            Sale receiver = new Sale(strategy, 100);

            //create command object
            GetTotalCommand getTotalCommand = new GetTotalCommand(receiver);

            //create invoker object and set command to test
            var invoker = new SaleInvoker();
            invoker.SetCommand(getTotalCommand);

            //Act
            invoker.Invoke();
            var result = getTotalCommand.Result;

            //Assert
            result.Should().Be(90m);
            
        }
    }
}
