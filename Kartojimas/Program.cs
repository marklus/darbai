using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartojimas
{
    class Program
    {
        static void Main(string[] args)
        {

            /*     
                  rasti visu skaiciu is [10-100] reziu kurie dalinasi is triju suma                         
             */

        /*    Console.WriteLine("Ivesk skaiciu");

           // var skaicius = Convert.ToInt32(Console.ReadLine()); 
           

    */
            var suma = 0;
            for (int i = 10; i < 100; i++)
            {
                if (i %3==0)
                {
                    suma += i;
                }

            }
            Console.WriteLine("suma"+suma);
        }
    }
}
