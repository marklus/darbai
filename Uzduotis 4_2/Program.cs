using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_4_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("iveskite simboli");
            var simbolis = Console.ReadLine();
            
            Console.WriteLine("");
            Console.WriteLine("{0}{0}{0}\n{0}{0}{0}\n{0}{0}{0}",simbolis);
        }
    }
}
