using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius");
            var s1=Convert.ToDouble(Console.ReadLine());
            var s2 = Convert.ToDouble(Console.ReadLine());
            var s3 = Convert.ToDouble(Console.ReadLine());

            if (s1 > s2 && s1 > s3)
            {
                Console.WriteLine("S1-max");
            }

            else if (s2 > s1 && s2 > s3)
            {
                Console.WriteLine("S2-max");
            }

            else if (s3 > s2 && s3 > s1)
            {
                Console.WriteLine("S3-max");
            }

            ///////////


            if (s1 < s2 && s1 < s3)
            {
                Console.WriteLine("S1-min");
            }

           else if (s2 < s1 && s2 < s3)
            {
                Console.WriteLine("S2-min");
            }

           else if (s3 < s2 && s3 < s1)
            {
                Console.WriteLine("S3-min");
            }
        }
    }
}
