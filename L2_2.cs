using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 127; i++)
            {
                char zeichen = (char)i;
                Console.Write($"{i, 3}: {zeichen, 2}, ".ToString());
                if (i%10==0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
