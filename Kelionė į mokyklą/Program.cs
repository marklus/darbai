using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelionė_į_mokyklą
{
    class Program
    {
        static void Main(string[] args)
        {

            //_______________________________Su_Namais___________________________________//

            Console.WriteLine("Kiek buvo valandų kai Petras išėjo iš namų:");
            int v1 = Convert.ToInt32(Console.ReadLine());
            int Valandos1_Į_Minutęs = v1 * 60; //Paversta į minutęs


            Console.WriteLine("Kiek buvo minučių kai Petras išėjo iš namų:");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek Trunka Petro kelionė į mokyklą?");
            int m2 = Convert.ToInt32(Console.ReadLine());

            int BendrasMinučiųSkaičius1= Valandos1_Į_Minutęs + m1 + m2;

            //_______________________________Su_Pamokom___________________________________//


            Console.WriteLine("Kelintą valandą prasideda pamoką:");
            int v = Convert.ToInt32(Console.ReadLine());
            int Valandos_Į_Minutęs = v * 60; //Paversta į minutęs

            Console.WriteLine("Kelintą minutę prasideda pamoką:");
            int m = Convert.ToInt32(Console.ReadLine());
            int BendrasMinučiųSkaičius = Valandos_Į_Minutęs + m;


            if (BendrasMinučiųSkaičius1 > BendrasMinučiųSkaičius)
            {
                Console.WriteLine("Petras į pamoką pavėluos");
            }

            else if (BendrasMinučiųSkaičius1 < BendrasMinučiųSkaičius)
            {
                Console.WriteLine("Petras į pamoką nepavėluos");
            }
        }
    }
}
