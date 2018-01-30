using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_0
{
    class Program
    {
        static void Main(string[] args)
        {

            //studentu pazymiai

            int[] pazymiai = { 10, 8, 3, 5, 8, 7, 9 };

            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[3]);           
            Console.WriteLine(pazymiai[5]);
            Console.WriteLine(pazymiai[6]);
            Console.WriteLine(pazymiai[2]);
            Console.WriteLine(pazymiai[0]);

            //3->4
            pazymiai[2] = 4;
            //5->1
            pazymiai[5] = 1;
            //0->9
            pazymiai[0] = 9;

            foreach (var pazymys in pazymiai)
            { 
                Console.WriteLine(pazymys+" "); 
            }



        
        }
    }
}
