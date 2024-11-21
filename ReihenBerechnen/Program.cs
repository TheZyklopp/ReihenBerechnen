using System;

namespace ReihenBerechnen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            uint n1 = 10;
            uint n2 = 25;
            uint n3 = 100;

            decimal sum1 = FakultaetVon(n1);
            decimal sum2 = FakultaetVon(n2);

            Console.WriteLine($"{sum1} und {sum2}");

            decimal erg1 = BerechneSumme1MitEndwert(n1);
            decimal erg2 = BerechneSumme1MitEndwert(n2);

            Console.WriteLine($"n=10: {erg1}");
            Console.WriteLine($"n=25: {erg2}");

            decimal erg3 = BerechneSumme2MitEndwert(n3);
            Console.WriteLine(erg3);
        }

        //gibt die Fakultät wieder.
        public static decimal FakultaetVon(uint zahl) //zahl ist der wert der weitergegeben wird also n1 und n2
        {
            decimal fakultaet = 1;

            for (uint i = 1; i <= zahl; i++) //rechnet immer das ergebnis * i++
            {
                fakultaet *= i;
            }            
            return (fakultaet); //gibt fakultaet wert an sum1 und sum2 weiter.
        }

        public static decimal BerechneSumme1MitEndwert(uint endwert)
        {
            decimal fakultaet = 1;
            decimal summe = 0;

            for (uint i = 1; i <= endwert; i++) //rechnet immer das ergebnis * i++
            {
                fakultaet *= i;
                
                decimal term = 1 / fakultaet;
                summe += term; //term wird auf die Summe rauf gerechnet.
            }
            return 1+summe; //1+ da die aufgabe vorne eine 1+ hat
        }
        public static decimal BerechneSumme2MitEndwert(uint endwert)
        {
            decimal summe = 0;

            for (uint n = 0; n <= endwert; n++) //rechnet immer das ergebnis  n++
            {
                decimal vorzeichen;
                if (n % 2 == 0)
                {
                    vorzeichen = 1; //wenn n gerade ist, ist das Vorzeichen 1
                }
                else
                {
                    vorzeichen = -1; //wenn n ungerade ist, ist das Vorzeichen -1
                }

                //berechne den Nenner des bruchs
                decimal nenner = 2 * n + 1;

                //berechne den Term
                decimal term = vorzeichen / nenner;
                summe += term;
            }
            return 4 * summe; //*4
        }
    }
}
