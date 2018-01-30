using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite egzamino rezultatą");
            var rez=Convert.ToInt32(Console.ReadLine());

            if (rez==100)
            {
                Console.WriteLine("mldc 100");
            }

            else if (rez>=80)
            {
                Console.WriteLine("mldc 80 arba daugiau");
            }

            else if (rez >= 50)
            {
                Console.WriteLine("mldc 50 arba daugiau");
            }

            else if (rez >= 20)
            {
                Console.WriteLine("mldc 20 arba daugiau");
            }

            else if (rez < 20)
            {
                Console.WriteLine("mldc 20 arba mažiau");
            }

        }
    }
}
