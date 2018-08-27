namespace BuilderTestSample.Model
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsExpedited { get; set; }
    }
}
