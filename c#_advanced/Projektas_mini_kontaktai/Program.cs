﻿namespace mini_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ProgramUI programUI = new ProgramUI();
                programUI.ShowMenu();
                programUI.UserChoice();
            }


            /*
            Užduotis: Sukurkite konsolinę programą, kuri tvarko paprastą adresų knygą.
            Kontaktai saugomi tekstiniame faile contacts.csv.

            Programos paleidimo metu vartotojui pateikiamas meniu su šiais pasirinkimais:
            - Pridėti Kontaktą
            - Peržiūrėti Kontaktus
            - Ištrinti Kontaktą
            - Ieškoti Kontakto
            - Išeiti

            Būtinos Klasės Projekto Įgyvendinimui:

            Kontakto  (Contact) klasės sąsaja:
                Ypatybės (Properties): Vardas (FirstName), Pavardė (LastName), Telefono Numeris (PhoneNumber), El. Paštas (Email).

            Adresų Knygos  (AddressBook) sąsaja:
                Metodai (Methods):
                    Pridėti Kontaktą (AddContact): Prideda naują kontaktą į adresų knygą.
                    Peržiūrėti Kontaktus (ViewContacts): Atspausdina visus kontaktus konsolėje.
                    Ištrinti Kontaktą (DeleteContact): Pašalina nurodytą kontaktą.
                    Ieškoti Kontakto (SearchContact): Ieško kontaktų pagal vardą arba pavardę.


            Programos naudotojo sąsajos (ProgramUI) klasės sąsaja:
                Metodai (Methods):
                    Rodyti Meniu (ShowMenu): Rodo pagrindinį meniu vartotojui.
                    Tvarkyti Vartotojo Pasirinkimą (HandleUserChoice): Tvarko vartotojo pasirinkimą iš meniu.
            */


        }
    }
}
