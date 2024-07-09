using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    internal class AddressBook
    {
        public void AddContact(Contact contact)
        {
            string filePath = "C:/dotnet_mokymai/c#_advanced/mini_project/contacts.csv";
            string contactData = $"{contact.FirstName},{contact.LastName},{contact.PhoneNumber},{contact.Email}";
            File.AppendAllText(filePath, contactData + Environment.NewLine);
        }
        public void ViewContacts()
        {
            string filePath = "C:/dotnet_mokymai/c#_advanced/mini_project/contacts.csv";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                Console.WriteLine($"Vardas: {data[0]}");
                Console.WriteLine($"Pavardė: {data[1]}");
                Console.WriteLine($"Telefono Numeris: {data[2]}");
                Console.WriteLine($"El. Paštas: {data[3]}");
                Console.WriteLine();
            }
        }
        public void DeleteContact(Contact contact)
        {
            string filePath = "C:/dotnet_mokymai/c#_advanced/mini_project/contacts.csv";
            string[] lines = File.ReadAllLines(filePath);
            List<string> updatedLines = new List<string>();
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] != contact.FirstName || data[1] != contact.LastName) 
                {
                    updatedLines.Add(line);
                }
            }
            File.WriteAllLines(filePath, updatedLines);
        }
        public void SearchContact(string search)
        {
            string filePath = "C:/dotnet_mokymai/c#_advanced/mini_project/contacts.csv";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                if (data[0] == search || data[1] == search)
                {
                    Console.WriteLine($"Vardas: {data[0]}");
                    Console.WriteLine($"Pavardė: {data[1]}");
                    Console.WriteLine($"Telefono Numeris: {data[2]}");
                    Console.WriteLine($"El. Paštas: {data[3]}");
                    Console.WriteLine();
                }
            }

        }
    }

}
