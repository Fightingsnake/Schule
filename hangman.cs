using System;

namespace hangman_2_2
{
    internal class Program
    {
        static (string[], int) Pruefen(string gewaehltesWort, char eingabe, string[] geratenes, int versuchszahl)
        {
            bool treffer = false;
            for (int i = 0; i < geratenes.Length; i++)
            {
                if (eingabe == gewaehltesWort[i])
                {
                    geratenes[i] = Convert.ToString(eingabe);
                    treffer = true;
                }
            }
            if (treffer)
            {
                Console.WriteLine($"Der Buchstabe {eingabe} war dabei!");
                treffer = false;
            }
            else
            {
                Console.WriteLine($"Leider war {eingabe} nicht dabei.");
                versuchszahl--;
                Console.WriteLine($"Du hast noch {versuchszahl}");
            }
            foreach (var item in geratenes)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            return (geratenes, versuchszahl);
        }
        static void Main(string[] args)
        {
            string[] worte4 = { "maus" /*, ....*/};
            string[] geraten = new string[] { "_", "_", "_", "_" };
            int versuche = 3, wahlDesWortes = 0;
            Console.WriteLine("Herzlich Willkommen. Du hast 3 Fehler uebrig um das richtige Wort zu erraten.\nDas Wort besteht aus 4 Buchstaben. Viel Erfolg.");
            do
            {
                try
                {
                    Console.Write("Deine Eingabe: ");
                    char eingabe = Convert.ToChar(Console.ReadLine());
                    (geraten, versuche) = Pruefen(worte4[wahlDesWortes], eingabe, geraten, versuche);
                }
                catch (Exception)
                {
                    Console.WriteLine("Sie haben ein falsches zeichen eingegeben. Bitte versuchen Sie es erneut.");
                }
            } while (versuche > 0);
            if (versuche > 0)
                Console.WriteLine("Du hast gewonnen! Glueckwunsch!");
            else
                Console.WriteLine("Leider hast du verloren.");
        }
    }
}
