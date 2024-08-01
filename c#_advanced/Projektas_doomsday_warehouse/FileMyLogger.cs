using project_doomsday_warehouse.Constructors;

namespace project_doomsday_warehouse
{
    public class FileMyLogger : IMyLogger
    {
        public void Log(string message)
        {
            try
            {
                File.AppendAllText("../../../logs.txt", message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while logging: " + ex.Message);
            }
        }
    }
    
}
