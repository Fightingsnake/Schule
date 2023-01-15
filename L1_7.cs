using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L1_7
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
        private static int[] Initialisieren(int laenge, int minRandom, int maxRandom)
        {
            Random r = new Random();
            int[] verzeichnis = new int[laenge];
            Thread.Sleep(10);
            for (int i = 0; i < laenge; i++)
            {
                verzeichnis[i] = r.Next(minRandom, maxRandom+1);
            }
            return verzeichnis;
        }
        static void Main(string[] args)
        {
            int countDown = 9;
            int[] integgies1 = Initialisieren(10, -40, 40);
            int[] geaenderte = new int[integgies1.Length];
            for (int i = 0; i < integgies1.Length; i++)
            {
                geaenderte[i] = integgies1[i] - integgies1[countDown];
                countDown--;
            }
            Ausgabe(integgies1);
            Ausgabe(geaenderte);
        }
    }
}
