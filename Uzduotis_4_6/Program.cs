using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Įveskite pirmąjį skaičių");
            var skaicius_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite antrąjį skaičių");
            var skaicius_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite trečiąjį skaičių");
            var skaicius_3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("\nVidurkis");
            Console.WriteLine((skaicius_1 + skaicius_2 + skaicius_3)/3);
        }
    }
}
