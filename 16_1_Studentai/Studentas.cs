using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_Studentai
{
    class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int UgisCM { get; set; }
        public int Amzius { get; set; }
        public char Lytis { get; set; }

        public Studentas(string vardas, string pavarde, int ugisCm, int amzius, char lytis)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            UgisCM = ugisCm;
            Amzius = amzius;
            Lytis = lytis;

        }

        public Studentas()
        {
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentas {0} {1} {2} {3} {4}", Vardas, Pavarde, UgisCM, Amzius, Lytis);
        }
    }
}
