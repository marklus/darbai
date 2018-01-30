using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7Uzduotis
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Skaicius");
            var sk1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaicius");
            var sk2 = Convert.ToInt32(Console.ReadLine());

            var atsakymas = 0;

            for (int i = 0; i < sk2; i++)
            {
                atsakymas += sk1;
            }
            Console.WriteLine("daugyba" + atsakymas);
        }
    }
}
