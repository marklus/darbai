using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pietus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek minučių mama gaminą pirmą patiekalą?");
            int t1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek minučių mama gaminą kitą patiekalą ilgiau nei pirmą?");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek minučių iki vaikų gryžimo?");
            int t = Convert.ToInt32(Console.ReadLine());


            int n = 0;

            for (int i = t1; i < t; i += t1 + k)
            {
                n++;

            }

            if (t<t1)
            {
                Console.WriteLine("Nespės pagaminti jokio patiekalo");
            }


            else
            Console.WriteLine("“Mama suspės pagaminti {0} patiekalus", n);

        }
    }
}
