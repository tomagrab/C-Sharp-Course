namespace QueueDemo.Models
{
    class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public Order(int orderId, int orderQuantity)
        {
            OrderId = orderId;
            OrderQuantity = orderQuantity;
        }
        public void ProcessOrder()
        {
            Console.WriteLine($"Processing order {OrderId} for {OrderQuantity} units.");
        }
    }
}