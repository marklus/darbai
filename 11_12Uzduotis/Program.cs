using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 1; i < 100; i++)
            {

                suma += i;

               if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }


                Console.WriteLine("{0}", i);
            }

            Console.WriteLine(suma);

        }
    }
}
