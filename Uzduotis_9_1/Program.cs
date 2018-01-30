using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_9_1
{
    class Program
    {
        static void Main(string[] args)
        {


            var a = 2;
            var b = 7;
            var c = 5;

            switch (a)
            {
                case 1:
                    Console.WriteLine(a + b + c);
                    break;
                case 2:
                    Console.WriteLine(a - c);
                    break;
                case 3:
                    Console.WriteLine(b*c);
                    break;

                default:
                    Console.WriteLine("Skaičius nerastas");
                    break;
            }


        }

        }
    }

