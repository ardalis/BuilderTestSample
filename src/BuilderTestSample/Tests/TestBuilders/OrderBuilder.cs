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

        public Order Build()
        {
            return _order;
        }

        public OrderBuilder WithTestValues()
        {
            _order.TotalAmount = 100m;

            // TODO: replace next lines with a CustomerBuilder you create
            // _order.Customer = new Customer();
            // _order.Customer.HomeAddress = new Address();

            return this;
        }
    }
}
