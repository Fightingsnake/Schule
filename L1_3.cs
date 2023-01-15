using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int counter = 0;
            while (counter < 10)
            {
                int zahl = random.Next(21, 85);
                if (zahl % 3 == 0 || zahl % 7 == 0)
                {
                    Console.WriteLine(zahl);
                    counter++;
                }
            }
        }
    }
}
