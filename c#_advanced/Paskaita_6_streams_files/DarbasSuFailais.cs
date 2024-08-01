using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_6_streams_files
{
    public class DarbasSuFailais
    {
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
        public void WriteAllText(string path, string text)
        {
            File.WriteAllText(path, text);
        }
        /*Kas negerai su šiuo metodu rašančiu eilutes į failą iš masyvo? Įvardinkite ir pataisykite.*/
        public void SupratimoUzduotis1(string path)
        {
            string[] lines = new string[] { "Line 1", "Line 2", "Line 3" };
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    writer.Write(line);
                }
            }
        }
        public void SupratimoUzduotis2()
        {
            string tekstas = "orem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                " Curabitur ultrices ipsum tortor, in faucibus mi gravida et. \r\n" +
                "Curabitur magna nisl, consequat ac efficitur quis, venenatis vel lectus.\r\n" +
                " Fusce id ipsum eu tellus varius fermentum id sed sapien. ";
            File.WriteAllText("tekstas2.txt", tekstas);
        }
        public void SupratimoUzduotis3(string path)
        {
            using (FileStream fs = new FileStream("example.txt", FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                string content = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(content);
            }
        }


        public string ReadFileContent(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }





    }
}
