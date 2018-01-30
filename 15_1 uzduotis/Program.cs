using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masinos

            Program programa = new Program();
            var nuvaziuotiKilometrazai = new List<int>();
            //skaiciavimu iskvietimui, kuris kvies atskirus metodus
            //metodai           
            //duomenu ivedimui
            //duomenu isvedimui
            //suma
            //min
            //max
            //vidurkis (vidurkis kviecia sumos metoda)
            //atrinkite i kita sarasa duomenis

            programa.Ivedimas(nuvaziuotiKilometrazai);
            programa.Isvedimas(nuvaziuotiKilometrazai,"Pradiniai duomenys");
            programa.Skaiciavimai(nuvaziuotiKilometrazai);


            List<int> atrinkti = programa.atrinkimas(nuvaziuotiKilometrazai);
            programa.Isvedimas(atrinkti,"Atrinkti duomenys");

        }
        public void Ivedimas(List<int> sarasas)
        {
            var dar = true;

            while (dar)
            {
                Console.WriteLine("Iveskite kilometraza ");
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("Norit kartot? t/n");
                var kartoti = Console.ReadLine();

                if (kartoti!="t")
                {
                    dar = false;
                }
            }
        }

        public void Isvedimas(List<int> sarasas, string komentaras)
        {
            Console.WriteLine(komentaras);
            Console.WriteLine("Pradiniai duomenys");

            foreach (var km in sarasas)
            {
                Console.WriteLine("[{0}]",km);                
            }
            Console.WriteLine();
        }

        public int Suma(List<int> sarasas)
        {
            return sarasas.Sum();
        }

        public int Min(List<int> sarasas)
        {
            return sarasas.Min();
        }

        public int Max(List<int> sarasas)
        {
            return sarasas.Max();
        }

        public double Vidurkis(List <int> sarasas)
        {
            var vidurkis = (Double)Suma(sarasas) / sarasas.Count;
            return vidurkis;
        }

        public void Skaiciavimai(List<int>sarasas)
        {
            Console.WriteLine("Suma "+ Suma(sarasas));
            Console.WriteLine("min " + Min(sarasas));
            Console.WriteLine("max " + Max(sarasas));
            Console.WriteLine("vidurkis " + Vidurkis(sarasas));
        }

        public List<int> atrinkimas(List<int> pradiniai)
        {
            var atrinkti = new List<int>();

            foreach (var km in pradiniai)
            {
                if (km>30000)
                {
                    atrinkti.Add(km);
                }
            }
            return atrinkti;
            
        }
    }
}
