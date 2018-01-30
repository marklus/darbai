using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įvesk teigiamą skaičių");
            var skaičius = Convert.ToInt32(Console.ReadLine());

            while (skaičius>0)
            {
                skaičius--;
                Console.WriteLine(skaičius);
            }


        }
    }
}
