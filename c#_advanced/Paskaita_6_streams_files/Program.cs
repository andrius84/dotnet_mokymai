namespace Paskaita_6_streams_files
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.
            //var darbasSuFailais = new DarbasSuFailais();
            //var path = "tekstas.txt"; 
            //var text = darbasSuFailais.ReadAllText(path);
            //Console.WriteLine(text);


            //2.
            var darbasSuFailais = new DarbasSuFailais();

            var tesktas = darbasSuFailais.ReadFileContent("tekstas.txt");


            //darbasSuFailais.SupratimoUzduotis1("tekstas.txt");



        }
    }
}
