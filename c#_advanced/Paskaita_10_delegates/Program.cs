namespace Paskaita_10_delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Supratimo12.A_Main();




        }

        /* KLAUSIMAS ===>> Jei vartotojas įveda "2" kaip savo pasirinkimą, kokia bus konsolėje išvedama reikšmė? kodėl?*/
        public class Menu
        {
            public event Action<int> OnMenuSelection;

            public void ShowMenu()
            {
                Console.WriteLine("Pasirinkite meniu punktą:");
                Console.WriteLine("1. Pasirinkimas 1");
                Console.WriteLine("2. Pasirinkimas 2");
                Console.WriteLine("3. Pasirinkimas 3");

                int selection = Convert.ToInt32(Console.ReadLine());

                // Suaktyviname įvykį
                OnMenuSelection?.Invoke(selection);
            }
        }
        public class Handler1
        {
            public void Subscribe(Menu menu)
            {
                menu.OnMenuSelection += HandleSelection;
            }

            private void HandleSelection(int selection)
            {
                if (selection == 1)
                {
                    Console.WriteLine("Handler1: Pasirinkimas 1 apdorotas.");
                }
            }
        }
        public class Handler2
        {
            public void Subscribe(Menu menu)
            {
                menu.OnMenuSelection += HandleSelection;
            }

            private void HandleSelection(int selection)
            {
                if (selection == 2)
                {
                    Console.WriteLine("Handler2: Pasirinkimas 2 apdorotas.");
                }
            }
        }
        public class Supratimo12
        {
            public static void A_Main()
            {
                Menu menu = new Menu();
                Handler1 handler1 = new Handler1();
                Handler2 handler2 = new Handler2();

                handler1.Subscribe(menu);
                handler2.Subscribe(menu);

                menu.ShowMenu();
            }
        }





    }
}

