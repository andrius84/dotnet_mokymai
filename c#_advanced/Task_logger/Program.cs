namespace Task_logger
{
    internal class Program
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
        public record Order(double Price, double Amount);   //modelis

        public interface IMyLogger
        {
            void Log(string message);
        }
        public class FileMyLogger : IMyLogger
        {
            public void Log(string message)
            {
                try
                {
                    File.AppendAllText("../../../log.txt", message + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while logging: " + ex.Message);
                }
            }
        }
        public class ConsoleMyLogger : IMyLogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        public interface IOrderService
        {
            Order PlaceOrder();
        }
        public class OrderService : IOrderService
        {
            private readonly List<IMyLogger> _loggers;
            public OrderService(IMyLogger logger)// Priklausomybių injekcija per konstruktorių
            {
                _loggers = new List<IMyLogger> { logger };
            }

            public Order PlaceOrder()
            {
                // Kažkokia biznio logika
                var order = new Order(0.1, 100);
                Log($"Naujas logas jeeeee. Price={order.Price}, Ammount={order.Amount} ");
                return order;
            }
            private void Log(string message) => _loggers.ForEach(logger => logger.Log(message));
        }
    }
}
