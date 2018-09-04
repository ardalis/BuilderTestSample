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

            if (order.Id != 0) throw new InvalidOrderException("Order ID must be 0.");

            if (order.TotalAmount <= 0) throw new InvalidOrderException("Order TotalAmount must exceed 0.");

            if (order.Customer == null) throw new InvalidOrderException("Order must have a Customer.");

            ValidateCustomer(order.Customer);
        }

        private void ValidateCustomer(Customer customer)
        {
            // throw InvalidCustomerException unless otherwise noted

            if (customer.Id <= 0) throw new InvalidCustomerException("Invalid ID");
            if (customer.HomeAddress == null) throw new InvalidCustomerException("No HomeAddress specified.");
            if (string.IsNullOrEmpty(customer.FirstName)) throw new InvalidCustomerException("No first name.");
            if (string.IsNullOrEmpty(customer.LastName)) throw new InvalidCustomerException("No last name.");

            // TODO: validate customer credit rating > 200 (otherwise throw InsufficientCreditException)
            if (customer.CreditRating <= 200) throw new InsufficientCreditException("Not enough credit.");
            // TODO: validate customer total purchases >= 0

            ValidateAddress(customer.HomeAddress);
        }

        private void ValidateAddress(Address homeAddress)
        {
            // throw InvalidAddressException unless otherwise noted

            // TODO: validate street1 is not null or empty
            // TODO: validate city is not null or empty
            // TODO: validate state is not null or empty
            // TODO: validate postalcode is not null or empty
            // TODO: validate country is not null or empty
        }

        private void ExpediteOrder(Order order)
        {
            // TODO: if credit rating > 500 and total purchases > 5000 set IsExpedited to true
        }

        private void AddOrderToCustomerHistory(Order order)
        {
            // TODO: add the order to the customer

            // TODO: update the customer's total purchases property
        }
    }
}
