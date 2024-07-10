namespace Paskaita_7_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.
            //Validation1.Validate<string>("null");

            //3.
            //var validation = new Validation<string, int>();
            //validation.ShowValueTypes("null", 0);

            //4.
            var my = new MySelfCreatedList<string>();
            my.AddElement("1");
            my.AddElement("2");
            my.AddElement("3");
            my.AddElement("4");
            my.AddElement("5");
            my.AddElement("6");
            my.AddElement("7");

            my.RemoveElement("2");
            my.RemoveElement("4");
        }
    }
}
