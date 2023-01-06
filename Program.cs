using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zaehler1 = 1, zaehler2 = 1, laenge = 1;
            int[] folge = new int[laenge];
            laenge = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= laenge; i++)
            {
                Console.WriteLine(zaehler1);
                zaehler1 += zaehler2;
                Console.WriteLine(zaehler2);
                zaehler2 += zaehler1;
            }
            Console.ReadLine();
        }
        
    }
}
