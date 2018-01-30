using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_00001
{
    class Program
    {
        static void Main(string[] args)
        {
            //skaiciavimu iskvietimui, kuris kvies atskirus metodus
            //metodai           
            //duomenu ivedimui
            //duomenu isvedimui
            //suma
            //min
            //max
            //vidurkis (vidurkis kviecia sumos metoda)
            //atrinkite i kita sarasa duomenis

            Program programa = new Program(); //susikuri kad galetum naudoti metodus be static 

        }

        public void ivedimas(List<int> sarasas)  //listas paminetas i kuri kraus ReadLine
        {
            var tesk=true;

            while (tesk)
            {
                Console.WriteLine("Ivesk");
                var km = Convert.ToInt32(Console.ReadLine());
                sarasas.Add(km);

                Console.WriteLine("Kartot t/n");
                var kartoti = Console.ReadLine();

                if (kartoti!="t")
                {
                    tesk = false;
                }

            }
        }

        public void isvedimas(List<int> sarasas)
        {
            Console.WriteLine("Pradiniai duomenys");

            foreach (var km in sarasas)
            {
                Console.WriteLine("[{0}]",km);
            }
            Console.WriteLine();

        }

    }
}
