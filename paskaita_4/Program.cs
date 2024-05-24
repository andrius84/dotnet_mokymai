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

        //4.Uzduotis
        int tt = 0, ii = 0, kk = 0, rr = 0, oo = 0, jj = 0, mm = 0, ee = 0, ll = 0;
        int tt2 = 0, ii2 = 0, kk2 = 0, rr2 = 0, oo2 = 0, jj2 = 0, mm2 = 0, ee2 = 0, ll2 = 0;
        Console.WriteLine("Iveskite pirma varda:");
        string vardas1 = Console.ReadLine();
        Console.WriteLine("Iveskite antra varda:");
        string vardas2 = Console.ReadLine();

        char[] vardas1arr = vardas1.ToCharArray();
        char[] vardas2arr = vardas2.ToCharArray();

        for (int i = 0; i < vardas1arr.Length; i++)
        {
            if ('t' == vardas1arr[i]) { tt++; };
            if ('i' == vardas1arr[i]) { ii++; };
            if ('k' == vardas1arr[i]) { kk++; };
            if ('r' == vardas1arr[i]) { rr++; };
            if ('o' == vardas1arr[i]) { oo++; };
            if ('j' == vardas1arr[i]) { jj++; };
            if ('m' == vardas1arr[i]) { mm++; };
            if ('e' == vardas1arr[i]) { ee++; };
            if ('l' == vardas1arr[i]) { ll++; };
        }

        for (int i = 0; i < vardas2arr.Length; i++)
        {
            if ('t' == vardas1arr[i]) { tt2++; };
            if ('i' == vardas1arr[i]) { ii2++; };
            if ('k' == vardas1arr[i]) { kk2++; };
            if ('r' == vardas1arr[i]) { rr2++; };
            if ('o' == vardas1arr[i]) { oo2++; };
            if ('j' == vardas1arr[i]) { jj2++; };
            if ('m' == vardas1arr[i]) { mm2++; };
            if ('e' == vardas1arr[i]) { ee2++; };
            if ('l' == vardas1arr[i]) { ll2++; };
        }

        Console.WriteLine(vardas1);
        if (tt > 0) { Console.WriteLine("t: " + tt); }
        if (ii > 0) { Console.WriteLine("i: " + ii); }
        if (kk > 0) { Console.WriteLine("k: " + kk); }
        if (rr > 0) { Console.WriteLine("r: " + rr); }
        if (oo > 0) { Console.WriteLine("o: " + oo); }
        if (jj > 0) { Console.WriteLine("j: " + jj); }
        if (mm > 0) { Console.WriteLine("m: " + mm); }
        if (ee > 0) { Console.WriteLine("e: " + ee); }
        if (ll > 0) { Console.WriteLine("l: " + ll); }

        Console.WriteLine(vardas2);
        if (tt2 > 0) { Console.WriteLine("t: " + tt2); }
        if (ii2 > 0) { Console.WriteLine("i: " + ii2); }
        if (kk2 > 0) { Console.WriteLine("k: " + kk2); }
        if (rr2 > 0) { Console.WriteLine("r: " + rr2); }
        if (oo2 > 0) { Console.WriteLine("o: " + oo2); }
        if (jj2 > 0) { Console.WriteLine("j: " + jj2); }
        if (mm2 > 0) { Console.WriteLine("m: " + mm2); }
        if (ee2 > 0) { Console.WriteLine("e: " + ee2); }
        if (ll2 > 0) { Console.WriteLine("l: " + ll2); }


        // 5. Uzduotis

        //int i = 1;
        //while ( i <= 5 )
        //{
        //    Console.WriteLine( i++ );
        //}

        //


    }
}