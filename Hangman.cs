using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static string Ausgabe(string[] wortZurAusgabe)
        {
            string ausgabe = "";
            int ausgabecounter = 0;
            foreach (var zeichen in wortZurAusgabe)
            {
                if (zeichen != null)
                    ausgabe += zeichen;
                else
                    ausgabe += "_";
                ausgabecounter++;
            }
            ausgabecounter = 0;
            return ausgabe;
        }
        static void Main(string[] args)
        {
            string[] worte4 = { "hund"/*, "maus", "zaun", "kanu", "pore", "pass", "reis"*/ };
            Random random = new Random();
            string wort = worte4[random.Next(worte4.Length)];
            string[] erraten = new string[wort.Length];
            int versuche = 3, zeichenzaehler = 0;
            while (true)
            {
                if (versuche == 0) 
                {
                    Console.WriteLine($"Sie haben das Spiel verloren. Das richtige Wort war: {wort.ToUpper()}");
                    break;
                }
                else
                {
                    Console.WriteLine(Ausgabe(erraten));
                    Console.WriteLine($"Du hast noch {versuche} Versuche!");
                    Console.Write("Gebe einen Buchstaben ein : ");
                    char eingabe = Convert.ToChar(Console.ReadLine());
                    foreach (var zeichen in wort)
                    {
                        if (eingabe == zeichen)
                        {
                            Console.WriteLine($"Richtig! Der Buchstabe ' {eingabe} ' kommt vor!");
                            erraten[zeichenzaehler] = Convert.ToString(eingabe);
                        }
                        else
                        {
                            zeichenzaehler++;
                        }
                    }
                    if (zeichenzaehler >= wort.Length)
                    {
                        versuche--;
                    }
                    zeichenzaehler = 0;
                }
            }
            Console.WriteLine("Das Spiel ist beendet.");
        }
    }
}
