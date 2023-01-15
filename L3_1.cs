using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool switchen = false;
            Console.Write("Gebe bitte eine Hoehe ein : ");
            int eingabeZeile = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nGebe bitte eine Breite ein : ");
            int eingabeSpalte = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int zeile = 1; zeile <= eingabeZeile; zeile++)
            {
                for (int spalte = 1; spalte <= eingabeSpalte; spalte++)
                {
                    if (switchen == false)
                    {
                        if (spalte == zeile || spalte == eingabeSpalte - zeile + 1)
                            Console.Write('X');
                        else
                            Console.Write(' ');
                        if (zeile > eingabeZeile/2)
                        {
                            switchen = true;
                        }
                    }
                    else
                    {
                        if (spalte <= zeile  && spalte >= eingabeSpalte - zeile+1)
                            Console.Write('X');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
