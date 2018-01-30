using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardas = "asdasd";
            var pavarde = "sdadsa";
            var amzius = 11;

            Isvedimas(vardas, pavarde, amzius);
            Ivedimas(ref vardas, ref pavarde, ref amzius);
            Isvedimas(vardas, pavarde, amzius);
        }

        public static void Ivedimas( ref string vardas, ref string pavarde, ref int amzius)
        {
            Console.WriteLine("Programoje ivestas vardas {0} \n iveskite naują: ",vardas);            
            vardas=Console.ReadLine();

            Console.WriteLine("Programoje ivesta pavarde {0} \n iveskite naują: ", pavarde);
            pavarde = Console.ReadLine();

            Console.WriteLine("Programoje ivestas amzius {0} \n iveskite naują: ", amzius);
            amzius = Convert.ToInt32(Console.ReadLine());

            
        }

        public static void Isvedimas(string vardas, string pavarde, int amzius)
        {
            Console.WriteLine("Vardas :{0} Pavarde: {1} Amzius: {2} (metų)",vardas, pavarde, amzius);
        }
    }
}
