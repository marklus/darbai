using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0_Pavyzdžiai
{
    class Program
    {
        static void Main(string[] args)
        {
            var pazymiai = new List<int>();
            Console.WriteLine("Iveskite pazymius, o noredami sustapdyti parasykite -1");
            int pazymys;

            do
            {
                pazymys = Convert.ToInt32(Console.ReadLine());
                if (pazymys != -1)
                {
                    pazymiai.Add(pazymys);


                }

            } while (pazymys!=-1);

            Console.WriteLine();

            foreach (var paz in pazymiai)
            {
                Console.WriteLine(paz);
            }






        }
    }
}
