using BuilderTestSample.Exceptions;
using BuilderTestSample.Model;

namespace BuilderTestSample.Services
{
    public class OrderService
    {
        public void PlaceOrder(Order order)
        {
            ValidateOrder(order);

            ExpediteOrder(order);

            AddOrderToCustomerHistory(order);
        }

        private void ValidateOrder(Order order)
        {
            // throw InvalidOrderException unless otherwise noted.

            // TODO: order ID should be zero (it's a new order)
            if (order.Id != 0) throw new InvalidOrderException("Order ID must be 0.");

            // TODO: order amount is greater than zero
            // TODO: order has a customer

            ValidateCustomer(order.Customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            // throw InvalidCustomerException unless otherwise noted

            // TODO: customer must have an ID
            // TODO: customer must have an address
            // TODO: ustomer must have a first and last name
            // TODO: customer must have credit rating > 200 (otherwise throw InsufficientCreditException)
            // TODO: customer must have total purchases >= 0

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted

            // TODO: street1 is required
            // TODO: city is required
            // TODO: state is required
            // TODO: postalcode is required
            // TODO: country is required
        }

        private void ExpediteOrder(Order order)
        {
            // TODO: if customer's total purchases > 5000 and credit rating > 500 set IsExpedited to true
        }

        private void AddOrderToCustomerHistory(Order order)
        {
            // TODO: add the order to the customer

            // TODO: update the customer's total purchases property
        }
    }
}
