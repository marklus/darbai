using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite skaičių");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            while (sk1 % 9!=0 )
            {
                sk1 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Dalinas is 9");
        }
    }
}
