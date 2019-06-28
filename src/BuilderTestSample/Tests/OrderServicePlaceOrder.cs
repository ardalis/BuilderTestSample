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
        public void ThrowsExceptionGivenOrderWithAmountZero()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .TotalAmount(0)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }
 
        [Fact]
        public void ThrowsExceptionGivenOrderWithNullCustomer()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(null)
                            .Build();

            Assert.Throws<InvalidOrderException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderWithCustomerWithId0()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(_customerBuilder.WithTestValues().Id(0).Build())
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Fact]
        public void ThrowsExceptionGivenOrderWithCustomerWithNullAddress()
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(_customerBuilder.WithTestValues().Address(null).Build())
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void ThrowsExceptionGivenOrderWithCustomerWithNoFirstName(string name)
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(_customerBuilder.WithTestValues().FirstName(name).Build())
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("  ")]
        public void ThrowsExceptionGivenOrderWithCustomerWithNoLastName(string name)
        {
            var order = _orderBuilder
                            .WithTestValues()
                            .Customer(_customerBuilder.WithTestValues().LastName(name).Build())
                            .Build();

            Assert.Throws<InvalidCustomerException>(() => _orderService.PlaceOrder(order));
        }

    }
}
