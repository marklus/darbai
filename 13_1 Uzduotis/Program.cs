using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 Ps1. 2 ps2. 3 ps3.");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas<0 || pasirinkimas>3 )
                {
                    Console.WriteLine("Blogai ivestas skaicius");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 2 ||pasirinkimas > 4);

            Console.WriteLine("pasirinkimas"+pasirinkimas);
        }
    }
}
