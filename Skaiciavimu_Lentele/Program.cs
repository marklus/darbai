using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skaiciavimu_Lentele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x      |x^2    |x^3|    1/x| ");
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i+"\t");
                Console.Write(i*i + "\t");
                Console.Write(i*i*i + "\t");
                Console.Write(Math.Round((double)1 / i, 2) + "\t");
                Console.WriteLine();
            }
        }
    }
}
