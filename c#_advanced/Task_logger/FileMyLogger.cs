namespace Task_logger
{
    internal partial class Program
    {
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
    }
}
