namespace Task_logger
{
    internal partial class Program
    {
       //     1. Pakeiskite pateiką programą taip, kad vietoje ConsoleMyLogger klasės būtų naudojamas FileMyLogger klasės objektas
       //- Keisti galima tik Main metodą, visą kitą kodą palikti nepakeistą.
       //- Galima pridėti naują klasę, bet nekeisti esamų.
        static void Main(string[] args)
        {           
            IMyLogger logger2 = new FileMyLogger();
            OrderService orderService2 = new OrderService(logger2);
            orderService2.PlaceOrder();
        }
    }
}
