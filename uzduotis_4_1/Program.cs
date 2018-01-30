using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzduotis_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite varda");
            var vardas = Console.ReadLine();
            Console.WriteLine("Iveskite amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());

           


                Console.WriteLine(("Jusu vardas- {0} o amzius {1}"),vardas, amzius);


        }
    }
}
