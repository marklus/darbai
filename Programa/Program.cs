using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            /* leisti vartotojui pasirinkti kiek duomenu jis nori suvest siuos duomenis sukelti i masyva rasti vidurki min max suma. atlikti atrinkima i kita masyva duomenu kurie tenkina sia salyga:
             * visos temperaturos kurios yra daugiau uz vidurki. abieju masyvu duomenis isvesti is atrinktu teperaturu masyvo rasti vidurki
             * 
             * 
             *///////////////////////////////////////////////////////////////////

            Console.WriteLine("Kiek duomenu nori suvesti");
            var kiek=Convert.ToInt32(Console.ReadLine());



            var temperaturos = new int[kiek];

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite {0}-aja temperatura: ", i+1);
                temperaturos[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var temperatura in temperaturos)
            {
                Console.WriteLine("[{0}]", temperatura);
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////
            //suma

            var suma = 0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
            }
            Console.WriteLine("Suma "+ suma);

            /////////////////////////////////////////////////////////////////////////
            //vidurkis


            var vidurkis = (double)suma/ temperaturos.Length;

            Console.WriteLine("Vidurkis "+ Math.Round(vidurkis,2));

            // Math Round suapvalina po kableleio skaicius rodo iki kiek skaiciu suapvalina


            /////////////////////////////////////////////////////////////////////////
            //maziausia temp

            var maziausias = temperaturos[0];

            foreach (var temp in temperaturos)
            {
                if (temp < maziausias)
                {
                    maziausias = temp;
                }
            }

            Console.WriteLine("maziausia "+ maziausias);

            /////////////////////////////////////////////////////////////////////////
            //didziausia temp

            var didziausias = temperaturos[kiek-1];

            foreach (var temp in temperaturos)
            {
                if (temp > maziausias)
                {
                    didziausias = temp;
                }
            }

            Console.WriteLine("didziausias " + didziausias);


            ///atrinkimas
            ///
            var atrinkta = new int[kiek];
            var kiekAtrinkta = 0;


            foreach (var temp in temperaturos)
            {
                if (temp>vidurkis)
                {
                    atrinkta[kiekAtrinkta] = temp;
                    kiekAtrinkta++;
                }
            }

            Console.WriteLine("ATRINKTI DUOMENYS");

            for (int i = 0; i < kiekAtrinkta; i++)
            {
                Console.WriteLine("[{0}]", atrinkta[i]);
            }

            Console.WriteLine();


        }
    }
}
