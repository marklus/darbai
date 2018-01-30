using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelionė_po_Lietuvą
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maršrutas = 320; //Panevėžys-Plungė-Panevėžys ilgis km

            Console.WriteLine("(k)Kiek Į kelionę planuoja vykti vienuoliktokų?");
            int k = Convert.ToInt32(Console.ReadLine());  ///Skaičius Žmonių

            Console.WriteLine("(t)Kiek kelionei kiekvienas vienuoliktokas gali skirti?");
            int t = Convert.ToInt32(Console.ReadLine());   //PINIGŲ SKAIČIUS

            Console.WriteLine("(d)Kokia kelionės trukmė ?");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(v)Kiek maistui per dieną vienam žmogui reikia eurų?");
            int v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(n)Kiek Litras benzino kainuoja eurų?");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("(b) Kokios degalų sąnaudos litrų šimtui kilometrų?");
            int b = Convert.ToInt32(Console.ReadLine());


            //  k*v*d maistui
            //k*t bendras
            //n/b kuro sąnaudos 

            double gal = k * t - (k * v * d + ((Maršrutas / b)/n));

            //______________________________IF_________________________//

            if (gal >=0 )
            {
                Console.WriteLine("Vienuoliktokai gali vykti į šią kelionę");
            }

            else if ( gal<0 )
            {
                Console.WriteLine("Vienuoliktokai negali vykti į šią kelionę");
            }
        }
    }
}
