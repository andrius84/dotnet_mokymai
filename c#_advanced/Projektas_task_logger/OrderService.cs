namespace Task_logger
{
    internal partial class Program
    {
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
