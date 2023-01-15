using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_2
{
    internal class Program
    {
        private static void Ausgabe(int[] verzeichnis, int maxDurchlaeufe)
        {
            
            Array.Sort(verzeichnis);
            Array.Reverse(verzeichnis);
            for (int i = 0; i < maxDurchlaeufe; i++)
            {
                Console.WriteLine($"{i+1}. Platz: {verzeichnis[i]}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] eingaben = new int[10];
            int[] anzeigen = new int[10];

            for (int eingabe = 0; eingabe < 10; eingabe++)
            {
                int usereingabe = Convert.ToInt32(Console.ReadLine());
                eingaben[eingabe] = usereingabe;
                Array.Copy(eingaben, anzeigen, 10);
                Ausgabe(anzeigen, eingabe+1);
            }
        }
    }
}
