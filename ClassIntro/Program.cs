using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.IzlenmeOrani = 100;
            kurs1.Egitmen = "engin demirog";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.IzlenmeOrani = 80;
            kurs2.Egitmen = "Kerem Varış";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.IzlenmeOrani = 70;
            kurs3.Egitmen = "Berkay Bilgin";

            Console.WriteLine(kurs1.KursAdi+" :: "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi+"::"+item.Egitmen);
            }
            

         

        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
