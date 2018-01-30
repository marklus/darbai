using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            var veiksmas = "t";

            while (veiksmas == "t")
            {
                Console.WriteLine("Įveskite skaičių");
                var sk1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Įveskite kitą skaičių");
                var sk2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Daugyba " + (sk1 * sk2));

                Console.WriteLine("Dalyba " + (sk1 / sk2));

                Console.WriteLine("Sudėtis " + (sk1 + sk2));

                Console.WriteLine("Atimtis" + (sk1 - sk2));

                Console.WriteLine("norite testi? t/n");
                veiksmas = Console.ReadLine();



            }
        }
    }
}
