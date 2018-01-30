using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_Studentai
{
    class Grupe
    {
        public List<Studentas> Studentai { get; set; } = new List<Studentas>(); // arba taip (= new List<Studentas>());
        /*public Grupe() //taip galima
        {
            Studentai = new List<Studentas>();
        }*/

        public Grupe()
        {
            Studentai.Add(new Studentas("labas","sd",180 , 20, 'v'));
            Studentai.Add(new Studentas("sveikas", "fdf", 180, 21, 'v'));
            Studentai.Add(new Studentas("idomu", "dgg",187 ,22 , 'm'));
            Studentai.Add(new Studentas("taiGerai", "fdf", 184, 23, 'm'));
            Studentai.Add(new Studentas("saunu", "sdad", 186, 24 , 'm'));

            var studentas = new Studentas("TOM", "JERRY", 30, 45, 'v');
            Studentai.Add(studentas);
        }

        public void Isvedimas()
        {
            foreach (var studentas in Studentai)
            {
                studentas.Isvedimas();
            }

            Console.WriteLine("Isvedimai");
            Console.WriteLine("Žemiausias Studentas");
            var zemiausias = ZemiausiasStudentas();
            zemiausias.Isvedimas();

            //ZemiausiasStudentas().Isvedimas();

        }

        


        // grupes klaseje nauji metodai
        //zemiausias studentas

        public Studentas ZemiausiasStudentas()
        {
            var zemiausias = Studentai.First();
            //var  zemiausias=Studentai[0];
            foreach (var studentas in Studentai)
            {
                if (studentas.UgisCM < zemiausias.UgisCM)
                {
                    zemiausias = studentas;
                }
            }

            return zemiausias;
        }
        //vyriausias studentas


        // kiek moteru
        // kiek vyru
        // amziu vidurkis
    }
}
