using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_0_1_Uzduotis
{
    class Automobilis
    {
        //prop->tab x 2

        //kintamieji
        public string Spalva { get; set; }
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public int Pavaros { get; set; }
        public double DarbinisTuris { get; set; }
        public int GaliKw { get; set; }

        //ctor = tuscias constructorius
        public Automobilis()
        {

        }
        public Automobilis(string spalva, string marke, string modelis, int rida, int pavaros,
            double darbinisTuris, int galiaKw)
        {

            Marke = marke;
            Modelis = modelis;
            Spalva = spalva;
            DarbinisTuris = darbinisTuris;
            Rida = rida;
            Pavaros = pavaros;
            GaliKw = galiaKw;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis{0} {1} duomenys", Marke, Modelis);

            Console.WriteLine("Spalva: " + Spalva);
            Console.WriteLine("Rida: " + Rida);
            Console.WriteLine("Pavaros: " + Pavaros);
            Console.WriteLine("Darbinis turis: " + DarbinisTuris);
            Console.WriteLine("Galia KW: " + GaliKw);
        }

        public void Ivedimas()
        {
            Console.WriteLine("Iveskite Markę: ");
            Marke = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Iveskite modeli: ");
            Modelis = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Iveskite Spalva: ");
            Spalva = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Iveskite Rida: ");
            Rida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Iveskite pavaras: ");
            Rida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Iveskite darbini turi: ");
            //DarbinisTuris = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string darTuris = Console.ReadLine();
            double darbTurisSk = 0.0; //kur saugosim skaicius jei pavyks konvertuoti
            bool pavyko = double.TryParse(darTuris, out darbTurisSk); //bandom bool pavyko=true;// vienintelis metodas su out

            if (pavyko)
            {
                DarbinisTuris = darbTurisSk;//priskiriam nauja reiksme
            }

            else
            {
                DarbinisTuris = 0;//priskiriam default
            }

            Console.WriteLine("Iveskite galia: ");
            GaliKw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Automobilis automobilis = new Automobilis();

            automobilis.Marke = "AAA";
            automobilis.Modelis = "BBB";
            automobilis.Spalva = "sdad";
            automobilis.DarbinisTuris = 2.0;
            automobilis.Rida = 1233123;
            automobilis.Pavaros = 5;
            automobilis.GaliKw = 150;

            Console.WriteLine(automobilis.Marke);
            Console.WriteLine(automobilis.Modelis);

            var auto2 = new Automobilis //kitas budas
            {
                Marke = "sdaf",
                Modelis = "jhkjlj",
                Spalva = "lkjjkh",
                DarbinisTuris = 5.0,
                Rida = 465646,
                Pavaros = 4,
                GaliKw = 300
            };

            Console.WriteLine(auto2.Marke);
            Console.WriteLine(auto2.Spalva);

            var auto3 = new Automobilis("melyna", "super", "kazkas",6, 5000, 2, 7);

            Console.WriteLine(auto3.Spalva);
            Console.WriteLine(auto3.Marke);

            automobilis.Isvedimas();
            Console.WriteLine();
            auto2.Isvedimas();
            Console.WriteLine();
            auto3.Isvedimas();
            Console.WriteLine();

            var auto4 = new Automobilis();
            auto4.Ivedimas();
            auto4.Isvedimas();

        }

    }

}
