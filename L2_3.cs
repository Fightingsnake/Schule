using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int eingabe = 25;//rnd.Next(1, 100); //Convert.ToInt32(Console.ReadLine());
            int maxFive, maxTwo;
            maxFive = eingabe / 5;
            maxTwo = eingabe / 2;
            Console.WriteLine($"Ihre Eingabe war: {eingabe}\nDie moeglichen Kombinationen sind:");
            //for (int i = 0; i <= maxFive; i++)
            //{
            //    int rest = eingabe;
            //    Console.Write($"5 Cent: {(eingabe / 5) - i*5,2} ; ");
            //    rest = eingabe - ((eingabe / 5) * 5)-i;
            //    Console.Write($"2 Cent: {(rest / 2) + i * 2,2} ; ");
            //    rest = rest - (rest / 2 * 2) + i * 2;
            //    Console.Write($"1 Cent: {rest,2}\n");
            //}
            for (int i5 = 0, i2 = 0, i1 = 0; i5 < eingabe && i2 <= eingabe && i1 < eingabe; i5 += 5, i2+=2, i1++)
            {
                Console.WriteLine($"5: {i5}       ;   2: {i2}        ;    1: {i1}");
            }
        }
    }
}
