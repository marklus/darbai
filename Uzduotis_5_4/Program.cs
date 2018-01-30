using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite penkis pažymius");
            var pažymys1=Convert.ToInt32(Console.ReadLine());

            var pažymys2 = Convert.ToInt32(Console.ReadLine());

            var pažymys3 = Convert.ToInt32(Console.ReadLine());

            var pažymys4 = Convert.ToInt32(Console.ReadLine());

            var pažymys5 = Convert.ToInt32(Console.ReadLine());
            Double Vidurkis = (pažymys1 + pažymys2 + pažymys3 + pažymys4+ pažymys5) /5;

            if (Vidurkis == 5)
            {
                Console.WriteLine("Vidurki lygus 5");

            }


            if (Vidurkis > 5)
            {
                Console.WriteLine("Vidurki didesnis už 5");

            }
        }
    }
}
