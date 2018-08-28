using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestSample.Model
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }
        
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address HomeAddress { get; set; }
        public int CreditRating { get; set; }
        public decimal TotalPurchases { get; set; }

        public List<Order> OrderHistory { get; set; } = new List<Order>();
    }
}
