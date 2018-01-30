using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dangus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite ar dangus giedras jei giedras 1, kitu atveju 0 ?");
            int ats = Convert.ToInt32(Console.ReadLine());

            if (ats==1)
            {
                Console.WriteLine("Dangus yra giedras");
            }

            else if(ats==0)
            {
                Console.WriteLine("Dangus nėra giedras");
            }
            else if(ats !=1 && ats !=0)
            {
                Console.WriteLine("Įvedėte blogą skaičių");
            }

        }


    }
}
