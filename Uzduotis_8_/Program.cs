using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius");
            var s1 = Convert.ToDouble(Console.ReadLine());
            var s2 = Convert.ToDouble(Console.ReadLine());
            var s3 = Convert.ToDouble(Console.ReadLine());

            double vidurkis = (s1 + s2 + s3) / 3;

            if (vidurkis>=8 && vidurkis==10)
            {
                Console.WriteLine("Įveskite tris skaičius");
            }

        }
    }
}
