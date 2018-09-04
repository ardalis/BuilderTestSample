using System;
using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class CustomerBuilder
    {
        private int _id;
        private Address _homeAddress;
        private string _firstName;
        private string _lastName;
        private int _creditRating;
        public const int TEST_CUSTOMER_ID = 123;

        public CustomerBuilder Id(int id)
        {
            // Id cannot be used because access to set is private
            // _customer.Id = id;
            _id = id;

            return this;
        }

        public CustomerBuilder HomeAddress(Address homeAddress)
        {
            _homeAddress = homeAddress;

            return this;
        }

        public CustomerBuilder FirstName(string firstName)
        {
            _firstName = firstName;

            return this;
        }

        public CustomerBuilder LastName(string lastName)
        {
            _lastName = lastName;

            return this;
        }

        public CustomerBuilder CreditRating(int creditRating)
        {
            _creditRating = creditRating;

            return this;
        }


        public Customer Build()
        {
            return new Customer(_id)
            {
                HomeAddress = _homeAddress,
                FirstName = _firstName,
                LastName = _lastName,
                CreditRating = _creditRating
            };
        }

        public CustomerBuilder WithTestValues()
        {
            _id = TEST_CUSTOMER_ID;
            _firstName = "TestFirst";
            _lastName = "TestLast";
            _creditRating = 500;

            // use AddressBuilder eventually
            _homeAddress = new Address();

            return this;
        }

    }
}
