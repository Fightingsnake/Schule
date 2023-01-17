using System;
using System.Threading;

namespace kreditkartennummer
{
    internal class Program
    {
        static int Quersumme(string zahl)
        {
            int summe = 0;
            foreach (var s in zahl)
                summe += s - 48;
            return summe;
        }
        static int RundeAuf(int zahl)
        {
            while (zahl % 10 != 0)
                zahl++;
            return zahl;
        }
        static void Main(string[] args)
        {
            //while (true)
            //{
                int additionQuersummen = 0, additionUngerade = 0;
                string zahlenFuerQuesumme;
                bool gueltig = false;
                int[] kreditkartennummer = new int[16];
 /*
                Random random = new Random();
                for (int ri = 0; ri < kreditkartennummer.Length; ri++)
                {
                    kreditkartennummer[ri] = random.Next(0, 10);
                    Thread.Sleep(10);
                }
                foreach (var i in kreditkartennummer)
                    Console.Write(i);
                Console.WriteLine();
                */
                Console.Write("Bitte geben Sie Ihre Kreditkartennummer ein : ");
                string eingabe = "4679864212400684";// Console.ReadLine();
                Console.WriteLine(eingabe);
                for (int i = 0; i < kreditkartennummer.Length; i++)
                    kreditkartennummer[i] = eingabe[i] - 48;
               
                for (int i = 0; i < kreditkartennummer.Length - 1; i++)
                {
                    if (i % 2 == 1)
                    {
                        kreditkartennummer[i] *= 3;
                        zahlenFuerQuesumme = Convert.ToString(kreditkartennummer[i]);
                        kreditkartennummer[i] = Quersumme(zahlenFuerQuesumme);
                        additionQuersummen += kreditkartennummer[i];
                    }
                    else
                        additionUngerade += kreditkartennummer[i];
                }
                int additionQuersummeUngerade = additionUngerade + additionQuersummen;
                int ergebnis = RundeAuf(additionQuersummeUngerade) - additionQuersummeUngerade;
                if (ergebnis == 10)
                    ergebnis = 0;
                if (ergebnis == kreditkartennummer[kreditkartennummer.Length - 1])
                    gueltig = true;
                else
                    gueltig = false;
                //var100 = var100 > 100 ? 20 : -20;
                //gueltig == true ? Console.WriteLine("Ihre Karte ist GUELTIG!") : Console.WriteLine("Ihre Karte ist ungueltig! Die Polizei wurde verstaendigt!");
                if (gueltig == true)
                {
                    Console.WriteLine("Ihre Karte ist GUELTIG!");
                  //  break;
                }
                else
                    Console.WriteLine("Ihre Karte ist ungueltig. Die Polizei wird verstaendigt.");
           // }
        }
    }
}
