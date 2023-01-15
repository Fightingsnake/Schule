using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wie breit soll dein Feld werden? : ");
            int breite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Wie hoch soll dein Feld werden? : ");
            int hoehe = Convert.ToInt32(Console.ReadLine());
            for (int zeile = 0; zeile < hoehe; zeile++)
            {
                for (int spalte = 0; spalte < breite; spalte++)
                {
                    if (zeile % 2 == 0)
                    {
                        if (spalte % 2 == 0)
                            Console.Write(' ');
                        else
                            Console.Write("|");
                    }
                    else
                    {
                        if (spalte % 2 == 0)
                            Console.Write("-");
                        else
                            Console.Write("+");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
