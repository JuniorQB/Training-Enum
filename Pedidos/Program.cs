using Pedidos.Entities;
using Pedidos.Entities.Enuns;

class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order
        {
            Id = 1,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        Console.WriteLine(order);

        string t1 = OrderStatus.Delivered.ToString() ;

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

        Console.WriteLine(os);
    }
}