using System.Collections;
using QueueDemo.Models;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order order in ReceivedOrdersFromBranch1())
            {
                ordersQueue.Enqueue(order);
            }

            foreach (Order order in ReceivedOrdersFromBranch2())
            {
                ordersQueue.Enqueue(order);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
        }

        static Order[] ReceivedOrdersFromBranch1()
        {
            Order[] orders = new Order[] {
                new Order(1, 10),
                new Order(2, 20),
                new Order(3, 30),
                new Order(4, 40)
            };

            return orders;
        }
        static Order[] ReceivedOrdersFromBranch2()
        {
            Order[] orders = new Order[] {
                new Order(5, 50),
                new Order(6, 60),
                new Order(7, 70),
                new Order(8, 80)
            };

            return orders;
        }
    }
}