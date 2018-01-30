using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_0_1_0_0pavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {

            var pinigai = new List<int>
            {
                56, 445, 454, 455, 147, 567, 122, 656, 548,
                414, 656, 112, 656
            };

            foreach (var pinigas in pinigai)
            {
                Console.WriteLine(pinigas);
            }


            //Rasti min max average

            //atrinkti i kita sarasa mazesnius uz vidurki

            //atrinkti sk tarp min ir max

            //min

            var maziausias = pinigai.Min();
            Console.WriteLine("Maziausias "+ maziausias);

            var didziausias = pinigai.Max();
            Console.WriteLine("Didziausias " + didziausias);

            var vidurkis = pinigai.Average();
            Console.WriteLine("Vidurkis " + Math.Round(vidurkis, 2));

            var mazesnisUzVid = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas < vidurkis)
                {
                    mazesnisUzVid.Add(pinigas);
                }

            }

            Console.WriteLine("mazesni uz vidurki" );

            foreach (var i in mazesnisUzVid)
            {
                Console.WriteLine(i);
            }

            //Atrrinkti ar lyginis

            var Lyginis = new List<int>();

            foreach (var pinigas in pinigai)
            {
                if (pinigas % 2 ==0)
                {
                    Lyginis.Add(pinigas);
                }

            }

            Console.WriteLine("Lyginiai ");

            foreach (var i in Lyginis)
            {
                Console.Write(i+" ");
            }
        }
    }
}
