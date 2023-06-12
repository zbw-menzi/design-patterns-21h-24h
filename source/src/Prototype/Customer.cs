﻿using System;

namespace Prototype
{
    public class Customer : BasicCustomerPrototype
    {
        public override object Clone()
        {
            return this.MemberwiseClone() as BasicCustomerPrototype;
        }
        public override Customer DeepClone()
        {
            var customer = this.MemberwiseClone() as Customer;

            customer.BillingAddress = new Address
            {
                StreetAddress = this.BillingAddress.StreetAddress,
                City = this.BillingAddress.City,
                Country = this.BillingAddress.Country,
                PostCode = this.BillingAddress.PostCode
            };

            customer.HomeAddress = new Address
            {
                StreetAddress = this.HomeAddress.StreetAddress,
                City = this.HomeAddress.City,
                Country = this.HomeAddress.Country,
                PostCode = this.HomeAddress.PostCode
            };

            return customer;
        }
    }
}