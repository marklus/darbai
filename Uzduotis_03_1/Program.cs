using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 21;
            double b = 3;


            Console.WriteLine("{0}*{1}={3}",a,b, a*b);
            Console.ReadLine();

            Console.WriteLine("{0}/{1}={3}", a, b, (double)a/b);
            Console.ReadLine();

            Console.WriteLine("{0}+{1}={3}", a, b, a+b);
            Console.ReadLine();

            Console.WriteLine("{0}-{1}= {3}", a, b, a-b);
            Console.ReadLine();

        }
    }
}
