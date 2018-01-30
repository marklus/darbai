using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = 8;

            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?\n");
            int kep = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla?\n");
            int dar = Convert.ToInt32(Console.ReadLine());


            int Diena = kep * H * dar;
            Console.WriteLine("Per vieną darbo dieną iškeps:{0} kepalų duonos\n",Diena);

////////////////////////////////////////////

            Console.WriteLine("Vieno kepalo savikaina?\n");
            double sav = Convert.ToDouble(Console.ReadLine());

            double VisosDienos = Diena * sav;
            Console.WriteLine("Visų kepalų savikaina yra {0} Eur\n", VisosDienos);

///////////////////////////////////

            Console.WriteLine("Vieno kepalo pardavimo kaina?\n");
            double kai = Convert.ToDouble(Console.ReadLine());

            double PajamosPardavus = (kai * VisosDienos);
            Console.WriteLine("Pajamos pardavus {0} Eur\n", PajamosPardavus);

            double plius = PajamosPardavus - VisosDienos;
            Console.WriteLine("Išėjo į pliusą ant {0} Eur\n", plius);


            Console.WriteLine("Kiek kepykla turi tą dieną užsakymų?\n");
            int uzs = Convert.ToInt32(Console.ReadLine());

            int Nespės = uzs - Diena;

            if (uzs<=Diena)
            {
                Console.WriteLine("Kepykla spės iškepti duonos kepalus\n");
            }

            else if (uzs >= Diena)
            {
                Console.WriteLine("Kepykla nespės iškepti duonos kepalus, liks neiškeptų kepalų duonos:{0}\n",Nespės);
            }
        }
    }
}
