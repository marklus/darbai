using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Į kelvinus");
            Console.WriteLine(273 + skaicius);

            Console.WriteLine("Į fahrenheitus");
            Console.WriteLine(1.8* skaicius);


        }
    }
}
