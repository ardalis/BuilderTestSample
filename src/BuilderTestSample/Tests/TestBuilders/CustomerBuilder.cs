using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class CustomerBuilder
    {
        public const int VALID_CUSTOMER_ID = 123;
        public const string TEST_FIRST_NAME = "First";
        public const string TEST_LAST_NAME = "Last";
        private Customer _customer;
        private int _id;
        private Address _address;
        private string _firstName;
        private string _lastName;

        public CustomerBuilder Id(int id)
        {
            _id = id;
            return this;
        }
        public CustomerBuilder Address(Address address)
        {
            _address = address;
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
        public Customer Build()
        {
            return new Customer(_id)
            {
                HomeAddress = _address,
                FirstName = _firstName,
                LastName = _lastName
            };
        }

        public CustomerBuilder WithTestValues()
        {
            _id = VALID_CUSTOMER_ID;
            _address = new Address();
            _firstName = TEST_FIRST_NAME;
            _lastName = TEST_LAST_NAME;

            return this;
        }
    }
}
