internal class Program
{
    private static void Main(string[] args)
    {

        //// 1. Uzduotis
        //var dm = DateTime.Now.ToString("yyyy");
        //int.TryParse(dm, out int ddm);
        //Console.WriteLine(dm,ddm);
        //Console.WriteLine("Iveskite savo gimimo metus:");
        //string im = Console.ReadLine();
        //int.TryParse(im, out int ism);
        //int lm = ddm - ism;
        //int lm2 = 90 - lm;
        //Console.WriteLine("Jums iki 90 liko:" + lm2 + " metu");
        //Console.WriteLine("Jums iki 90 liko menesiu: " + lm2 * 12 + " menesiu");
        //Console.WriteLine("Jums iki 90 liko dienu: " + lm2 * 365 + " dienu");

        //// 2. Uzduotis

        //Console.WriteLine("Iveskite zodi:");
        //string zodis = Console.ReadLine();
        //char[] zodisarr = zodis.ToCharArray();
        //char raide = zodisarr[0];
        //if (Char.IsUpper(raide))
        //{
        //    Console.WriteLine("Pirmoji raide didzioji");
        //    Console.WriteLine(zodis.ToUpper());
        //}
        //else
        //{
        //    Console.WriteLine("Pirmoji raide mazoji");
        //    zodisarr[0] = char.ToUpper(zodisarr[0]);
        //    Console.WriteLine(zodisarr);
        //}

        //// 3. Uzduotis

        //Console.WriteLine("Iveskite zodi >labas<:");
        //string zlabas = Console.ReadLine();
        //char[] zlabasarr = zlabas.ToCharArray();
        //char[] atvirkscias = zlabas.Reverse().ToArray();
        //if (zlabas == "labas")
        //{
        //    Console.WriteLine(atvirkscias);
        //}
        //else
        //{
        //    Console.WriteLine(zlabas);
        //}

        // 4. Uzduotis
        //int tt = 0, ii = 0, kk = 0, rr = 0, oo = 0, jj = 0, mm = 0, ee = 0, ll = 0;
        //Console.WriteLine("Iveskite pirma varda:");
        //string vardas1 = Console.ReadLine();
        //Console.WriteLine("Iveskite antra varda:");
        //string vardas2 = Console.ReadLine();

        //char[] vardas1arr = vardas1.ToCharArray();

        //if ('t' == vardas1arr[0]) { tt++; };
        //if ('i' == vardas1arr[0]) { ii++; };
        //if ('k' == vardas1arr[0]) { kk++; };
        //if ('r' == vardas1arr[0]) { rr++; };
        //if ('o' == vardas1arr[0]) { oo++; };
        //if ('j' == vardas1arr[0]) { jj++; };
        //if ('m' == vardas1arr[0]) { mm++; };
        //if ('e' == vardas1arr[0]) { ee++; };
        //if ('l' == vardas1arr[0]) { ll++; };

        //Console.WriteLine(vardas1);
        //Console.WriteLine($"t({tt} i({ii}) k({kk}) r({rr}) o({oo}) j({jj}) m({mm}) e({ee}) l({ll})");

        // 5. Uzduotis

        int i = 1;
        while ( i <= 5 )
        {
            Console.WriteLine( i++ );
        }

        //


    }
}