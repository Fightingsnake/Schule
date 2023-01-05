using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schulprojekt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe, aktGroesste, aktKleinste, zaehler=0, summe = 0, durchschnitt;
            int[] eingaben = new int[10];
            Console.Write($"Bitte gebe die {1+ zaehler}. Zahl ein: ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            aktGroesste = eingabe;
            aktKleinste = aktGroesste;
            eingaben[zaehler] = eingabe;
            while (zaehler < 8)
            {
                Console.Write($"Bitte gebe die {2+ zaehler}. Zahl ein: ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                if (eingabe > aktGroesste)
                {
                    aktGroesste = eingabe;
                }
                else if (eingabe < aktKleinste)
                {
                    aktKleinste = eingabe;
                }
                summe += eingabe;
                zaehler++;
                eingaben[zaehler] = eingabe;
            }
            durchschnitt = summe / 7;
            Console.WriteLine($"Die groesste Zahl war: {aktGroesste}\nDie kleinste Zahl war: {aktKleinste}");
            Console.WriteLine($"Die Summe ist {summe}\nDer Durchschnitt des Gesamten lautet {durchschnitt}");
            for (int i = 0; i < eingaben.Length; i++)
            {
                Console.WriteLine(eingaben[i]);
            }
            Console.Read();
        }
    }
}







/*
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kleinste, anfang, groesste, zaehler = 6;
            string eingabe;
            anfang = Convert.ToInt32(Console.ReadLine());
            kleinste = anfang;
            groesste = anfang;
            while (zaehler > 0)
            {
                Console.WriteLine($"Bitte gebe die {7 - zaehler}. Zahl ein");
                eingabe = Console.ReadLine();
                int tf;
                bool wahr = int.TryParse(eingabe, out tf);
                if (wahr)
                {
                    Console.WriteLine($"Bitte gebe die {8 - zaehler}. Zahl ein");
                    if (tf < kleinste)
                    {
                        kleinste = tf;
                    }
                    else if (tf > groesste)
                    {
                        groesste = tf;
                    }
                    zaehler--;

                }
                else
                {
                    Console.WriteLine("Bitte gebe nur Zahlen ein");
                    return;
                }
                Console.WriteLine($"Die kleinste Zahl ist {kleinste}");
                Console.WriteLine($"Die groesste Zahl ist {groesste}");
            }
            Console.ReadLine();
        }
    }
}
*/