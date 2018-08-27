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

            // order ID should be zero (it's a new order)
            if (order.Id != 0) throw new InvalidOrderException("Order ID must be 0.");

            // order amount is greater than zero
            // order has a customer

            ValidateCustomer(order.Customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            // throw InvalidCustomerException unless otherwise noted
            // customer has an ID
            // customer has an address
            // customer has a first and last name
            // customer credit rating > 200 (otherwise throw InsufficientCreditException)
            // customer total purchases >= 0

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted
            // street1 is required
            // city/state/postalcode/country are required
        }

        private void ExpediteOrder(Order order)
        {
            // if credit rating > 500 and total purchases > 5000 set IsExpedited to true
        }

        private void AddOrderToCustomerHistory(Order order)
        {
            // add the order to the customer

            // update the customer's total purchases property
        }
    }
}
