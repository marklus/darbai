using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite tris skaičius atskirai");
            var skaičius1 = Convert.ToDouble(Console.ReadLine());
            var skaičius2 = Convert.ToDouble(Console.ReadLine());
            var skaičius3 = Convert.ToDouble(Console.ReadLine());


            if (skaičius1 > skaičius2)
            {

                Console.WriteLine("skaičius1 didesnis už antrą");
            }

            else if(skaičius1<skaičius2)
            {

                Console.WriteLine("skaičius1 mažesnis už antrą");
            }
            /////////////////
            if (skaičius2 > skaičius3)
            {

                Console.WriteLine("skaičius2 didesnis už trečią");
            }

            else if (skaičius2 < skaičius3)
            {

                Console.WriteLine("skaičius2 mažesnis už trečią");
            }
            ////////////////
            if (skaičius3 > skaičius1)
            {

                Console.WriteLine("skaičius3 didesnis už pirmą");
            }

            else if (skaičius3 < skaičius1)
            {

                Console.WriteLine("skaičius3 mažesnis už pirmą");
            }
            ///////////////


            if (skaičius1 == skaičius2)
            {

                Console.WriteLine("skaičius1 lygus skaičiui2");
            }

            else if (skaičius1 != skaičius2)
            {

                Console.WriteLine("skaičius1 nelygus skaičiui2");
            }
        }
    }
}
