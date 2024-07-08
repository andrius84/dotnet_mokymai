using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project
{
    internal class ProgramUI
    {
        public void ShowMenu()
        {
            Console.WriteLine("Pasirinkite veiksmą:");
            Console.WriteLine("1. Pridėti Kontaktą");
            Console.WriteLine("2. Peržiūrėti Kontaktus");
            Console.WriteLine("3. Ištrinti Kontaktą");
            Console.WriteLine("4. Ieškoti Kontakto");
            Console.WriteLine("5. Išeiti");
        }

        public void HandleUserChoice()
        {
            AddressBook addressBook = new AddressBook();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Įveskite vardą:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Įveskite pavardę:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Įveskite telefono numerį:");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("Įveskite el. paštą:");
                    string email = Console.ReadLine();
                    Contact contact = new Contact(firstName, lastName, phoneNumber, email);
                    addressBook.AddContact(contact);
                    break;
                case "2":
                    addressBook.ViewContacts();
                    break;
                case "3":
                    Console.WriteLine("Įveskite vardą arba pavardę:");
                    string search = Console.ReadLine();
                    addressBook.SearchContact(search);
                    break;
                case "4":
                    Console.WriteLine("Įveskite vardą arba pavardę:");
                    string delete = Console.ReadLine();
                    addressBook.DeleteContact(delete);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Neteisingas pasirinkimas.");
                    break;
            }
        }

    }
}
