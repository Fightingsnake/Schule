using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Monte_Carlo_Methode
{
    internal class Program
    {
        static bool Minus()
        {
            Random random = new Random();
            int x = random.Next(1, 101);
            Thread.Sleep(2);
            if (x >= 50)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int[] punkt = new int[2];
            Dictionary<double, double> keyValuePairs = new Dictionary<double, double>();
            int kreis = 1, imKreis = 0, ausserhalb = 0;
            double anzahl = 200000.0;
            int[] quadr = new int[2] { -1, 1 };
            Random random = new Random();
            for (int i = 1; i < anzahl; i++)
            {
                double x = random.NextDouble(), y = random.NextDouble();
                if (Minus() == true) // x
                    x *= -1;
                if (Minus() == true) // y
                    x *= -1;
                keyValuePairs.Add(x, y);
                if (i%100==0)
                    Console.WriteLine($"{x}, {y}");

            }
            foreach (KeyValuePair<double, double> punktwerte in keyValuePairs)
            {
                if (Math.Pow(punktwerte.Key, 2) + Math.Pow(punktwerte.Value, 2) >= 1)
                    ausserhalb++;
                else
                    imKreis++;

            }
            Console.WriteLine($"Innerhalb: {imKreis}\nAusserhalb: {ausserhalb}");
            double ergebnis = imKreis * 4 / anzahl;
            Console.WriteLine(ergebnis);
        }
    }
}
