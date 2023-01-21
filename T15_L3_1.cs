using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_1
{
    internal class T15_L3_1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int eingabe;
            int[] eingaben = new int[3];
            bool weiter = true;
            Console.WriteLine("Der Computer denkt an eine Zahl zwischen 1 und 15. Sie haben 3 Versuche.");
            while (weiter)
            {
                int versuche = 3;
                int wahl = random.Next(1, 16);
                do
                {
                    try
                    {
                        if (versuche == 1)
                            Console.WriteLine("Du hast noch 1 Versuch... Streng dich an!");
                        Console.Write("Ihre Eingabe ist: ");
                        eingabe = Convert.ToInt32(Console.ReadLine());
                        eingaben[versuche - 1] = eingabe;
                        if (eingabe != wahl && versuche > 0)
                        {

                            if (eingabe > wahl)
                            {
                                Console.WriteLine("Die eingegebene Zahl war zu gross.");
                                versuche--;
                            }
                            else
                            {
                                Console.WriteLine("Die eingegebene Zahl war zu klein.");
                                versuche--;
                            }
                        }
                        else if (eingabe == wahl)
                        {
                            Console.WriteLine($"Sie haben das Spiel gewonnen! {wahl} war die richtige Zahl!\nMoechten Sie eine weitere Runde spielen? ( Y / N ) : ");
                            try
                            {
                                char antwort = Convert.ToChar(Console.ReadLine());
                                if (antwort == 'y')
                                {
                                    Console.WriteLine("Viel Spass");
                                    break;
                                }
                                else if (antwort == 'n')
                                    weiter = false;
                                else
                                    Console.WriteLine("Damit kann ich nichts anfangen. Spinner.");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Du hast eine falsche eingabe getaetigt. Versuche es erneut.");
                            }

                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Du sollst Zahlen eingeben. Idiot.");
                    }
                } while (versuche > 0);
                if (versuche == 0)
                {
                    Console.WriteLine($"Sie haben das Spiel verloren. Die gesucht Zahl war {wahl}. \n{eingaben[versuche]} war ihre letzte Eingabe.");
                    weiter = false;
                }
            }
        }
    }
}