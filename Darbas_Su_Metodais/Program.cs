using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbas_Su_Metodais
{
    class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();          
            var laipsniai = new List<double>();
            programa.ivedimas(laipsniai);
            programa.isvedimas(laipsniai,"");
            programa.Skaiciavimai(laipsniai);

        }

        public void ivedimas(List<double> sarasas)
        {
            var kol = true;

            while (kol)
            {
                Console.WriteLine("Iveskite temperaturas: ");
                var temp = Convert.ToDouble(Console.ReadLine());
                sarasas.Add(temp);

                Console.WriteLine("Ar dar karta rasysi? t/n");
                var rasysiu = Console.ReadLine();

                if (rasysiu!="t")
                {
                    kol = false;
                }
                Console.WriteLine();
            }
        }

        public void isvedimas(List<double> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            Console.WriteLine("Pradiniai duomenys");

            foreach (var c in sarasas)
            {
                Console.WriteLine("[{0}]", c);
            }
        }

        public double Suma(List<double> sarasas)
        {
            return sarasas.Sum();
        }

        public double Min(List<double> sarasas)
        {
            return sarasas.Min();
        }

        public double Max(List<double> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List<double> sarasas)
        {
            var vidurkis = (Double)Suma(sarasas) / sarasas.Count;
            return Math.Round(vidurkis, 2);
        }

        public void Skaiciavimai(List<double> sarasas)
        {
            Console.WriteLine("Suma " + Suma(sarasas));
            Console.WriteLine("min " + Min(sarasas));
            Console.WriteLine("max " + Max(sarasas));
            Console.WriteLine("vidurkis " + Vidurkis(sarasas));
        }

        public List<double> atrinkimas(List<double> pradiniai)
        {
            var atrinkti = new List<double>();

            foreach (var tmp in pradiniai)
            {
                if (tmp > 20)
                {
                    atrinkti.Add(tmp);
                }
            }
            return atrinkti;


        }
    }
}
