using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uždarbis
{
    class Program
    {
        static void Main(string[] args)
        {
            var uzdarbiai = new List<double>();
            double uzdarbis;
            

            Console.WriteLine("Kiek norite mėnesių suvesti algas");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Parašykite kiek žmogus uždirbo per tam tik(rą)(us) mėnes(į)(ius).");
            Console.WriteLine();
            do
            {

                uzdarbis = Convert.ToDouble(Console.ReadLine());
                if (uzdarbis!=-1)
                {
                    uzdarbiai.Add(uzdarbis);
                    kiek--;
                }

            } while (kiek>0);

            Console.WriteLine();
            Console.WriteLine("Suvestos algos");

            foreach (var uzd in uzdarbiai)
            {
                Console.WriteLine(uzd);

            }

            var suma = (double)uzdarbiai.Sum();
            Console.WriteLine("Bendra uždarbių suma "+ (Math.Round((double)suma,2)));

           
        }
    }
}
