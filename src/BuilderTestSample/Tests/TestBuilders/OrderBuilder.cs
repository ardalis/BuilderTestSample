using BuilderTestSample.Model;

namespace BuilderTestSample.Tests.TestBuilders
{
    /// <summary>
    /// Reference: https://ardalis.com/improve-tests-with-the-builder-pattern-for-test-data
    /// </summary>
    public class OrderBuilder
    {
        private Order _order = new Order();

        public OrderBuilder Id(int id)
        {
            _order.Id = id;
            return this;
        }

        public OrderBuilder TotalAmount(int totalAmount)
        {
            _order.TotalAmount = totalAmount;
            return this;
        }

        public OrderBuilder Customer(Customer customer)
        {
            _order.Customer = customer;
            return this;
        }

        public Order Build()
        {
            return _order;
        }

        public OrderBuilder WithTestValues()
        {
            _order.TotalAmount = 100m;

            // replace with CustomerBuilder eventually
            _order.Customer = new Customer(CustomerBuilder.TEST_CUSTOMER_ID);

            _order.Customer.HomeAddress = new Address();

            return this;
        }
    }
}
