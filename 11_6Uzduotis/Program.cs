using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite pradzia");
            var pr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite pabaigą");
            var pb = Convert.ToInt32(Console.ReadLine());

            if (pr < pb)
            {
                for (int i = pr; i < pb; i++)
                {
                    if (i %2!=0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }

            }
        }
    }
}
