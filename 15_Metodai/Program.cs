using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Metodai
{
    class Matematika
    {
        public static int Suma(int a, int b)
        {
            return a + b;
        }

        public static int skirtumas(int a, int b)
        {
         /*   Console.WriteLine("Rasyk skaiciu");
            var sk1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rasyk kita skaiciu");
            var sk2 = Convert.ToInt32(Console.ReadLine());
            */
            var skirtumas = a - b;
            return skirtumas;
        }

        public static int daugyba(int a, int b)
        {
            var daugyba = a * b;
            return daugyba;

        }

        public static int dalyba(int a, int b)
        {
            var dalyba = a / b;
            return dalyba;

        }

 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program.Pasisveikinti();//Per klase kviesta
            Atsisveikinti();

            var Programa = new Program(); // objektas kuriamas viena karta
            Programa.Pinigai();
            Programa.Automobilis();

            var suma = Matematika.Suma(5, 4);
            Console.WriteLine(suma);

            var skirtumas = Matematika.skirtumas(7, 3);
            Console.WriteLine(skirtumas);

            var daugyba= Matematika.daugyba(6, 8);
            Console.WriteLine(daugyba);

            var dalyba = Matematika.dalyba(2, 1);
            Console.WriteLine(dalyba);
        }


        static public void Pasisveikinti()
        {
            Console.WriteLine("Koks jusu vardas ponas? ");
            Console.WriteLine("Labas," + Console.ReadLine());
        }

        static public void Atsisveikinti()
        {
            Console.WriteLine("Ate ");
        }

        public void Pinigai()
        {
            Console.WriteLine("Pasakykite ka daro pinigai");
            var pinigai = Console.ReadLine();
            Console.WriteLine("Lol prie bajerio tu");
            Console.WriteLine(pinigai);
        }

        public void Automobilis()
        {
            Console.WriteLine("KA vairuojate?");
            var auto = Console.ReadLine();
            if (auto=="peugeot")
            {
                Console.WriteLine("Very nice ");
            }

        }

    }
}
