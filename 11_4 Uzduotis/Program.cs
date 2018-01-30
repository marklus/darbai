using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_Uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                   Console.WriteLine("{0}", i);
                }
             
            }

            var vardai = new string[7];

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine("Iveskite varda");
                vardai[i] = Console.ReadLine();
            }


            Console.WriteLine();

            foreach (var vardas in vardai)
            {
                Console.Write( vardas + ", " ); 
            }

            Console.WriteLine();


            //pazymiai
            Console.WriteLine("Kiek pazymiu norite?");
            var kiek=Convert.ToInt32(Console.ReadLine());

            var pazymiai2 = new int[kiek];

            for (int i = 0; i < pazymiai2.Length; i++)
            {
                Console.WriteLine("Iveskite{0}-aji pazymi",i+1);
                pazymiai2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var pazymys in pazymiai2)
            {
                Console.Write(pazymys + ", ");
            }

            //algoritmas


            var suma = 0;

            foreach (var pazymys in pazymiai2)
            {
                suma += pazymys;
                //suma=suma+pazymys;
            }
            Console.WriteLine("Suma:"+suma);
            //algoritmas

            var maziausias = pazymiai2[0];

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys<maziausias)
                {
                    maziausias = pazymys;
                }
            }

            Console.WriteLine("maziausias"+maziausias);

            //Console.WriteLine("maziausias"+pazymiai2.Min()); nevisur veikia sita eilute bet cia tinka.

            //algoritmas - max pazymys

            var didziausias = pazymiai2[0];

            foreach (var pazymys in pazymiai2)
            {
                if (pazymys > didziausias)
                {
                    didziausias = pazymys;
                }
            }

            Console.WriteLine("didziausias" + didziausias);

            //Console.WriteLine("didziausias"+pazymiai2.Max());
        }
    }
}
