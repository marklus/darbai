using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var skaicius=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(skaicius * skaicius);
        }
    }
}
