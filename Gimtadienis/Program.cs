using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimtadienis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite kiek draugų kvies Ramunė:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Įveskite kiek draugų kvies Saulius:");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek Turi bendrų draugų");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kokia didžiausią pinigų sumą " +
                "iš savo sutaupytų pinigų vaikai gali skirti kiekvienam svečiui:");
            double g = Convert.ToDouble(Console.ReadLine());

            double k = g/(r + s + d);

           
            Console.WriteLine("Iš savo sutaupytų pinigų vaikai gali skirti kiekvienam svečiui {0:n2}",k);
           
        }
    }
}
