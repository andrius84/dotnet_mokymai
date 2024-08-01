namespace Task_logger
{
    internal partial class Program
    {
        public class ConsoleMyLogger : IMyLogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
