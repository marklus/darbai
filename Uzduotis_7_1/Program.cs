using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius");
            var sk1 = Convert.ToDouble(Console.ReadLine());
            var sk2 = Convert.ToDouble(Console.ReadLine());
            

            if (sk1 > sk2)
            {
                Console.WriteLine("sk1>sk2");
            }

            else if (sk1 < sk2)
            {
                Console.WriteLine("sk1<sk2");
            }

            else
            { Console.WriteLine("sk1=sk2"); }
        }
    }
}
