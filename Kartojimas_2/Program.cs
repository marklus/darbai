using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*sudeti i masyva skaicius kurie dalinasi is 5 ir patenka tarp 30-150 reziu masyva isvesti graziai */

            var skaiciai = new int[120];
            var indeksas = 0;

            for (int i = 30; i <= 150; i++)
            {
                if (i % 5==0)
                {
                    skaiciai[indeksas] = i;
                    indeksas++;

                }
            }

            for (int i = 0; i < indeksas; i++)
            {
                Console.Write("[{0}]", skaiciai[i]);
            }
            Console.WriteLine();
            /* foreach (var skaicius in skaiciai)
             {
                 Console.Write("[{0}]",skaicius);
             } 
             */

            //rasti skaiciu suma, maz ir didz skaicius, vidurki
            //sumos paieska

            var suma = 0;

            for (int i = 0; i < indeksas; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine("suma "+suma);

            //vidurkis

            var vidurkis = suma / indeksas;
            Console.WriteLine("viduekis "+ vidurkis);

            //didz

            var didz = skaiciai[indeksas-1];

            Console.WriteLine("Didziausias "+didz);

            //maz 

            var maz = skaiciai[0];

            Console.WriteLine("Maziausias " + maz);



        }
    }
}
