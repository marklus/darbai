using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite sveikąjį skaičių");
            var Skaičius =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Daugybos lentelė iki penkių kartų");

            Console.WriteLine(Skaičius * 1);
            Console.WriteLine(Skaičius * 2);
            Console.WriteLine(Skaičius * 3);
            Console.WriteLine(Skaičius * 4);
            Console.WriteLine(Skaičius * 5);

        }
    }
}
