using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L2_4
{
    internal class Program
    {
        private static void Ausgabe(int[] verzeichnis)
        {
            foreach (var item in verzeichnis)
            {
                Console.Write($"{item,5}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            for (int tests = 0; tests <= 15; tests++)
            { 
                int[] Lottozahlen = new int[49];
                int[] gezogen = new int[6];
                for (int i = 0; i < Lottozahlen.Length; i++)
                {
                    Lottozahlen[i] = i + 1;
                }
                for (int i = 0; i < gezogen.Length; i++)
                {
                    Random random = new Random();
                    Thread.Sleep(20);
                    int wahl = random.Next(Lottozahlen.Length);
                    int Lottozahl = Lottozahlen[wahl];
                    if (Lottozahl != 0)
                    {
                        gezogen[i] = Lottozahl;
                        Lottozahlen[wahl] = 0;
                    }
                }
                Ausgabe(gezogen);
            }
        }
    }
}
