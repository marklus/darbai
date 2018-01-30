using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            var pazymiai = new List<int>();
            int pazymys;
            var kiek = 0;
            do
            {
                Console.WriteLine("Rasyk ");
                pazymys = Convert.ToInt32(Console.ReadLine());
                if (pazymys != -1)
                {
                    pazymiai.Add(pazymys);
                    kiek++;
                }


            } while (pazymys!=-1);

            foreach (var paz in pazymiai)
            {
                Console.WriteLine(paz);
            }



            var maziausias = pazymiai.Min();
            Console.WriteLine("Maziausias " + maziausias);

            var didziausias = pazymiai.Max();
            Console.WriteLine("Didziausias"+ didziausias);

            var vidurkis = pazymiai.Average();
            Console.WriteLine("Vidutinis "+ Math.Round(vidurkis,2));

            var vidurkis = new Random();
            var random = vidurkis.Next(kiek);
        }
    }
}
