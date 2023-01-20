using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp8
{
    internal class Program
    {
        private static double[] Initialisieren(int laenge, int minRandom, int maxRandom)
        {
            Random r = new Random();
            double[] verzeichnis = new double[laenge];
            Thread.Sleep(10);
            for (int i = 0; i < laenge; i++)
            {
                verzeichnis[i] = r.NextDouble() * r.Next(minRandom, maxRandom+1);
                Math.Round(verzeichnis[i], 2);
            }
            return verzeichnis;
        }
        private static void Ausgabe(double[] verzeichnis)
        {
            foreach (var item in verzeichnis)
            {
                Console.Write($"{item, 5:F2}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            double[] doubles1 = Initialisieren(10, 0, 50);
            double[] doubles2 = Initialisieren(10, 0, 50);
            double[] ergebnis = new double[10];
            for (int position = 0; position < ergebnis.Length; position++)
            {
                if (doubles1[position] + doubles2[position] >= 60)
                    ergebnis[position] = 1;
                else
                    ergebnis[position] = 0;
            }
            Ausgabe(doubles1);
            Ausgabe(doubles2);
            Console.WriteLine(new string ('-', 69));
            Ausgabe(ergebnis);
        }
    }
}
