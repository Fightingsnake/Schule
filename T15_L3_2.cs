using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace T15_L3_2
{
    internal class T15_L3_2
    {
        static void Ausgabe(int[] zahlen)
        {
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.Write($"{zahlen[i],3} ; ");
            }
            Console.WriteLine();
        }
        static int[] SortArray(int[] array)
        {
            int length = array.Length;
            int temp = array[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static (int, double) RechtsLauf(int Position, double teiler, int laengeArray)
        {
            teiler /= 2;
            int naechster = (int)(laengeArray * teiler);
            if ((int)(teiler * laengeArray) < 1)
                naechster = 1;
            Position += naechster;
            return (Position, teiler);
        }
        static (int, double) LinksLauf(int Position, double teiler, int laengeArray)
        {
            teiler /= 2;
            int naechster = (int)(laengeArray * teiler);
            if ((int)(teiler * laengeArray)< 1)
                naechster= 1;
            Position -= naechster;
            return (Position, teiler);
        }
        static void Main(string[] args)
        {
            int[] sortArray = new int[50];
            Random random = new Random();
            double naechsterSchritt = 0.5;
            for (int i = 0; i < sortArray.Length; i++)
            {
                sortArray[i] = random.Next(1, 60);
                Thread.Sleep(2);
            }
            Ausgabe(sortArray);
            SortArray(sortArray);
            Ausgabe(sortArray);
            Console.WriteLine("Geben Sie bitte die gewuenschte Zahl ein: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            double position = sortArray.Length * naechsterSchritt;
            do
            {
                
                if (eingabe == sortArray[(int)position])
                {
                    Console.WriteLine($"Die gesuchte Zahl {eingabe} befindet sich an Position: {(int)position}");
                    break;
                }
                else if (eingabe > sortArray[(int)position])
                {
                    Console.WriteLine($"alte position {(int)position} ; alter teiler {naechsterSchritt}");
                    (position, naechsterSchritt) = RechtsLauf((int)position, naechsterSchritt, sortArray.Length);
                    Thread.Sleep(400);
                    //Console.WriteLine($"neue position {position} ; neuer teiler {naechsterSchritt}");
                }
                else if (eingabe < sortArray[(int)position])
                {
                    Console.WriteLine($"alte position {(int)position} ; alter teiler {naechsterSchritt}");
                    (position, naechsterSchritt) = LinksLauf((int)position, naechsterSchritt, sortArray.Length);
                    Thread.Sleep(400);
                    //Console.WriteLine($"neue position {position} ; neuer teiler {naechsterSchritt}");
                }
            } while (true);
        }
    }
}
