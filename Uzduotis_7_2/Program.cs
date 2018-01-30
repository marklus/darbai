using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite du skaičius");
            var sk1 = Convert.ToDouble(Console.ReadLine());
          


            if (sk1 == 0)
            {
                Console.WriteLine("lygus 0");
            }

            else if (sk1 > 0)
            {
                Console.WriteLine("Skaičius teigiamas");
            }

            else
            { Console.WriteLine("Skaičius neigiamas"); }

        }
    }
}
