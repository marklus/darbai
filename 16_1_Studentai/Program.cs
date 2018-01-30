using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_Studentai
{
    class Program
    {
        static void Main(string[] args)
        {



            var stud1 = new Studentas("sdads", "asdas",170 ,22 , 'v');
            var stud2 = new Studentas("fhgjh", "vcbvb", 160, 24, 'v');
            var stud3 = new Studentas("sveikas", "labas", 189, 36, 'v');
            var stud4 = new Studentas("vbnvm", "nnmn", 177, 124, 'm');
            var stud5 = new Studentas("qwrw", "uio", 150, 128, 'm');

            stud1.Isvedimas();
            stud2.Isvedimas();
            stud3.Isvedimas();
            stud4.Isvedimas();
            stud5.Isvedimas();
            Console.WriteLine();

            var grupe = new Grupe();
            grupe.Isvedimas();



        }

    }
}
