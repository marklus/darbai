using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            var sakinys = "";

            var ivedimas = "";

            while (ivedimas != "exit")
            { 
                Console.WriteLine("Įveskite žodį arba exit");
                ivedimas = Console.ReadLine();
                if (ivedimas!="exit")
                {
                    sakinys += ivedimas + " ";
                }

            }
            Console.WriteLine(sakinys);
        }
    }
}
