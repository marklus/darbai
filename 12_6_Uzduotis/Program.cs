using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Atspėk skaičių");
            var Skaičius = Convert.ToInt32(Console.ReadLine());
            var Slaptas = new Random();

            var Atspėk = Slaptas.Next(1, 10);

            while (Atspėk != Skaičius)
            {
                                            
                if (Atspėk == Skaičius)
                {
                    Console.WriteLine("Lol atspėjai LMAO");
                }

                else if (Atspėk > Skaičius)
                {
                    Console.WriteLine("Neatspėjai Skaicius didesnis:(");

                }

                else if (Atspėk < Skaičius)
                {
                    Console.WriteLine("Neatspėjai Skaicius mazesnis:(");

                }

                Console.WriteLine("ivekiset");//irgi


                Skaičius = Convert.ToInt32(Console.ReadLine()); ///Prisiminti ideti i gala

            }
        }
    }
}
