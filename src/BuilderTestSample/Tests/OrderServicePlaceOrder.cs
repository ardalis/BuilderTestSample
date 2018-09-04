using BuilderTestSample.Exceptions;
using BuilderTestSample.Services;
using BuilderTestSample.Tests.TestBuilders;
using Xunit;

namespace BuilderTestSample.Tests
{
    public class OrderServicePlaceOrder
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly OrderBuilder _orderBuilder = new OrderBuilder();
        private readonly CustomerBuilder _customerBuilder = new CustomerBuilder();

        [Fact]
        public void ThrowsExceptionGivenOrderWithExistingId()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Id(123)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderAmountOfZero()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .TotalAmount(0)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderWithNoCustomer()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(null)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithoutId()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .Id(0)
                            .Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(customer)
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenCustomerWithNullAddress()
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .HomeAddress(null)
                            .Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(customer)
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionGivenCustomerWithNullOrEmptyFirstName(string firstName)
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .FirstName(firstName)
                            .Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(customer)
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowsExceptionGivenCustomerWithNullOrEmptyLastName(string lastName)
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .LastName(lastName)
                            .Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(customer)
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData(200)]
        [InlineData(199)]
        [InlineData(0)]
        public void ThrowsExceptionGivenCustomerWith200OrLowerCreditRating(int creditRating)
        {
            var customer = _customerBuilder
                            .WithTestValues()
                            .CreditRating(creditRating)
                            .Build();

            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(customer)
                            .Build();

            Assert.Throws<InsufficientCreditException>(() => _orderService.PlaceOrder(order));
        }


    }
}
