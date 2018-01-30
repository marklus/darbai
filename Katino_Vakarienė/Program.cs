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
            Console.WriteLine("Kiek iš viso žuvų pagavo katinas?");
            int VisoZuvu = Convert.ToInt32(Console.ReadLine());
            int parnestos = 0;
            double BendrasSvoris = 0;
            int KiekDideliu = 0;
            int KiekSkaniu = 0;

            while (VisoZuvu != 0)
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

                VisoZuvu--;
            }

            Console.WriteLine("Atsakymas:{0} žuvelės, {1} kg. ", parnestos, BendrasSvoris);
        }
    }
}