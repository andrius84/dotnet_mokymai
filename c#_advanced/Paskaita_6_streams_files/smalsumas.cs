using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_6_streams_files
{
    public class smalsumas
    {
        public void OptimizacijosUzdavinys(string patch, int samples)
        {
            var timer = new Stopwatch();
            Console.WriteLine("Tikrinime File.ReadAllLines efektyvuma");
            timer.Start();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadAllLines(patch);
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readAllLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine("File.ReadAllLines uztruko: " + readAllLinesTime + "ms");

            Console.WriteLine("Tikrinime File.ReadLines efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(patch);
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readLinesTime = timer.ElapsedMilliseconds;
            Console.WriteLine("File.ReadLines uztruko: " + readLinesTime + "ms");

            Console.WriteLine("Tikriname File.ReadLines kartu su ToArray efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var lines = File.ReadLines(patch).ToArray();
                foreach (var line in lines)
                {
                    //do something
                }
            }
            timer.Stop();
            var readLinesToArrayTime = timer.ElapsedMilliseconds;
            Console.WriteLine("File.ReadLines kartu su ToArray uztruko: " + readLinesToArrayTime + "ms");

            Console.WriteLine("Tikriname File.ReadAllText o poto split efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                var text = File.ReadAllText(patch).Split('\n');
                foreach (var line in text)
                {
                    //do something
                }
            }
            timer.Stop();
            var readAllTextTime = timer.ElapsedMilliseconds;
            Console.WriteLine("File.ReadAllText o poto split uztruko: " + readAllTextTime + "ms");

            Console.WriteLine("Tikriname StreamReader efektyvuma");
            timer.Restart();
            for (int i = 0; i < samples; i++)
            {
                using (var reader = new StreamReader(patch))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //do something
                    }
                }
            }
            timer.Stop();
            var streamReaderTime = timer.ElapsedMilliseconds;
            Console.WriteLine("StreamReader uztruko: " + streamReaderTime + "ms");


        }
    }
}
