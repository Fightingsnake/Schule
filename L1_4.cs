using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int zeile = 1; zeile <= 7; zeile++)
            {
                for (int spalte = 1; spalte <= 7; spalte++)
                {
                    if (spalte <= zeile)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
