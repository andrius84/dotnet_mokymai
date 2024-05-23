namespace paskaita_3
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Kuria uzduoti norite atlikti (1,2,3?):");
            string nrr = Console.ReadLine();
            var nr = int.Parse(nrr);
            switch (nr)
            {
                case 1:
                    Console.WriteLine("Iveskite teksta:");
                    string sk = Console.ReadLine();
                    var skarr = sk.ToCharArray();
                    skarr[0] = char.ToUpper(skarr[0]);
                    Console.WriteLine(skarr);
                    break;
                case 2:
                    Console.WriteLine("Iveskite teksta:");
                    string text = Console.ReadLine();
                    string res = text.Replace('2', 'g').Replace('4', 'b').Replace('6', '*').Replace('8', 'x').Replace("10", 'w'.ToString());
                    Console.WriteLine(res);
                    break;
                case 3:
                    Console.WriteLine("Iveskite 5 simboliu teksta:");
                    string text5 = Console.ReadLine();
                    char[] textarr = text5.ToCharArray();
                    if (textarr.Length == 5)
                    {
                        Console.WriteLine("Kaip norite uzkoduoti pranesima, iveskite viena skaiciu:");
                        string kodas = Console.ReadLine();
                        int kodassk = int.Parse(kodas);
                        if (kodas.Length != 1)
                        {
                            Console.WriteLine("Ivestas kodas neatitinka reikalavimu");
                        }
                        else
                        {                         
                            textarr[0] = (char)(textarr[0] + kodassk);
                            textarr[1] = (char)(textarr[1] + kodassk);
                            textarr[2] = (char)(textarr[2] + kodassk);
                            textarr[3] = (char)(textarr[3] + kodassk);
                            textarr[4] = (char)(textarr[4] + kodassk);

                            console.WriteLine("Uzkoduotas tekstas:");
                            Console.WriteLine(textarr);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ivestas tekstas neatitinka reikalavimu");
                    }
                    break;

                default:
                    Console.WriteLine("Tokios uzduoties nera");
                    break;


            }
        }
    }
}
