using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L1_2
{
    internal class Program
    {
        private static void Ausgabe(int[] verzeichnis)
        {
            foreach (var item in verzeichnis)
            {
                Console.Write($"{item,5} ");
            }
            Console.WriteLine();
        }
        private static int[] Initialisieren(int laenge)
        {
            Random r = new Random();
            int[] verzeichnis = new int[laenge];
            Thread.Sleep(10);
            for (int i = 0; i < laenge; i++)
            {
                verzeichnis[i] = r.Next(0,100);
            }
            return verzeichnis;
        }
        static void Main(string[] args)
        {
            int[] integ1 = Initialisieren(10);
            int[] integ2 = Initialisieren(10);
            int[] produkt = new int[10];
            for (int i = 0; i < produkt.Length; i++)
            {
                produkt[i] = integ1[i] * integ2[i];
            }
            Ausgabe(integ1);
            Ausgabe(integ2);
            Ausgabe(produkt);
        }
    }
}
