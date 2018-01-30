using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite neigiamą skaičių");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius<=0)
            {
                Console.WriteLine(skaicius++);
            }
        }
    }
}
