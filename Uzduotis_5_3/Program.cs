using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite teigiamą skaičių");

            var skaičius=Convert.ToInt32(Console.ReadLine());


            if (skaičius < 0)
            {

                Console.WriteLine("Raminkis vartotojau");
            }

            else { Console.WriteLine("Šaunuolis vartotojau"); }


            if (skaičius % 2 == 0)
            {
                Console.WriteLine("Skaičius lyginis");
            }

            if (skaičius % 4 == 0)
            {
                Console.WriteLine("Skaičius lyginis");
            }


            if (skaičius > 10)
            {

                Console.WriteLine("Skaičius didesnis už 10 ");

            }
        }
    }
}
