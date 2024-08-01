using System;

namespace Paskaita_2_class_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ManoKlase manoKlase = new ManoKlase();
            //manoKlase.ManoMetodas();
            //ManoKlase.ManoStatinisMetodas();

            //var manoklase2objektas = new ManoKlase2();
            //manoklase2objektas.KintamojoPakeitimas();
            //manoklase2objektas.ManoMetodas();
            //var manoklase2objektas2 = new ManoKlase2();
            //manoklase2objektas2.ManoMetodas();

            //var numbersList = new NumbersList();
            //numbersList.AddNumber(5);
            //numbersList.AddNumber(10);
            //numbersList.AddNumber(15);
            //numbersList.PrintList();


            //var rectangle = new Rectangle();
            //rectangle.Width = 5;
            //rectangle.Height = 10;
            //Console.WriteLine("Plotas: " + rectangle.GetArea());
            //Console.WriteLine("Perimetras: " + rectangle.GetPerimeter());


            List<Library> Books = new List<Library>();
            Books.Add(new Library());

            Books[0].AddBook("Book1");
            Books[0].AddBook("Book2");
            Books[0].AddBook("Book3");

            


        }
    }
}
