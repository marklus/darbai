using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katino_Vakarienė
{
    class Program
    {
        static void Main(string[] args)
        {

            int parnestos = 0;
            double BendrasSvoris = 0;
            int KiekDideliu = 0;
            int KiekSkaniu = 0;
            char testi ;
            Console.WriteLine("Ar katinas pagavo bent vieną žuvį t=taip, n=ne ");
            var ArPagavo = Convert.ToChar(Console.ReadLine());

            if (ArPagavo=='t')
            {
                do
                {
                    Console.WriteLine("Ar žuvis buvo skani 1=taip, 0=Ne");
                    int Atsakymas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Koks žuvelės svoris? ");
                    Double Svoris = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    if (Svoris > 1 && Atsakymas == 1)
                    {
                        parnestos++;
                        BendrasSvoris += Svoris;
                    }

                    if (Svoris > 1)
                    {
                        KiekDideliu++;
                    }

                    if (Atsakymas == 1)
                    {
                        KiekSkaniu++;
                    }

                    Console.WriteLine("Ar dar žuvų yra? t-taip, n-ne.");
                    testi = Convert.ToChar(Console.ReadLine());

                } while (testi == 't');

                Console.WriteLine("Atsakymas:{0} žuvelės, {1} kg. ", parnestos, BendrasSvoris);
                Console.WriteLine("Didelių žuvelių - {0}, skanių žuvelių - {1} kg. ", KiekDideliu, KiekSkaniu);
            }

            else
            {
                Console.WriteLine("Katinas nieko nepagavo");
            }
        }
    }
}