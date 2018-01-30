using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daugybos_Lentelė
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int t = 1; t <= 10; t++)
                {
                    Console.Write(i*t + "\t");
                }
                Console.Write(" \n");
            }
            
        }
    }
}
