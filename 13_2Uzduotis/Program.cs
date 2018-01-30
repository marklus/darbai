using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_9Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            var suma_2 = 0;
            var SumKv = 0;

            for (int i = 0; i <= 100; i++)
            {

                suma += i * i;

            }

            for (int i = 0; i <= 100; i++)
            {

                SumKv += i;

            }

            int skaicius = SumKv * SumKv;

            Console.WriteLine("Atsakymas: " + suma);

            suma_2 = skaicius - suma;

            Console.WriteLine("Atsakymas: " + suma_2);
        }
    }
}