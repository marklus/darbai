using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite savo amžių");

            var amžius =Convert.ToInt32(Console.ReadLine());


            if (amžius >= 18)
            {
                Console.WriteLine("jūs galite balsuoti");


            }

            else
            {
                Console.WriteLine("jūs negalite balsuoti");

            }
        }
    }
}
