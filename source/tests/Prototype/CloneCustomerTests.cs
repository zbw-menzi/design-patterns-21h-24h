using FluentAssertions;
using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zbw.DesignPatterns.Adapter;

namespace Zbw.DesignPatterns.Tests.Prototype
{
    public class CloneCustomerTests
    {
        [Fact]
        public void DeepCloneCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Hans",
                LastName = "Muster",

                BillingAddress = new Address
                {
                    StreetAddress = "Teststrasse 33",
                    City = "St.Gallen",
                    PostCode = "9000",

                },

                HomeAddress = new Address
                {
                    StreetAddress = "Musterstrasse 33",
                    City = "Zürich",
                    PostCode = "8000",
                }
            };
            // Act
            var customerClone = customer.DeepClone();

            // Assert
            customerClone.BillingAddress.Should().NotBeSameAs(customer.BillingAddress);
        }

        [Fact]
        public void CloneCustomer()
        {
            // Arrange
            var customer = new Customer
            {
                FirstName = "Hans",
                LastName = "Muster",

                BillingAddress = new Address
                {
                    StreetAddress = "Teststrasse 33",
                    City = "St.Gallen",
                    PostCode = "9000",

                },

                HomeAddress = new Address
                {
                    StreetAddress = "Musterstrasse 33",
                    City = "Zürich",
                    PostCode = "8000",
                }
            };
            // Act
            var customerClone = customer.Clone();

            // Assert
            customerClone.Should().NotBeSameAs(customer.BillingAddress);
        }
    }
}
