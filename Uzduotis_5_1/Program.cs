using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite pirmą skaičių");
            var pirmas=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrą skaičių");
            var antras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečią skaičių");
            var trečias = Convert.ToInt32(Console.ReadLine());

            //1
            if (pirmas == antras)
            {
                Console.WriteLine("Pirmas Antras Skaičiai lygūs");

            }
            else
            {
                Console.WriteLine("Pirmas Antras Skaičiai Nelygūs"); 
            }

            //2
            if (antras == trečias)
            {
                Console.WriteLine("Antras Trečias Skaičiai lygūs");

            }

            else
            {
                Console.WriteLine("Antras trečias Skaičiai Nelygūs");
            }

            //3
            if (pirmas > antras)
            {
                Console.WriteLine("Pirmas skaičius yra didesnis už antrą skaičių");

            }

            else
            {
                Console.WriteLine("Pirmas nėra didesnis už antrą");
            }

            //4
            if (antras > (trečias*2))
            {
                Console.WriteLine("antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę ");

            }

            else
            {
                Console.WriteLine("antras nėra didesnis už dvigubą trečią skaičių");
            }

            //5
            if (pirmas % 2==0)
            {
                Console.WriteLine("pirmas skaičius yra lyginis ");

            }

            else
            {
                Console.WriteLine("Pirmas skaičius nėra lyginis");
            }

            //6
            if (antras % 2 != 0)
            {
                Console.WriteLine("antras skaičius yra nelyginis ");

            }

            else
            {
                Console.WriteLine("Antras skaičius yra lyginis");
            }

            //7
            if (trečias > 0)
            {
                Console.WriteLine("Trčias skaičius yra teigiamas ");

            }

            //8
            else {

                Console.WriteLine("Trečias skaičius nėra teigiamas");
            }


        }
    }
}
