using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Don't repeat yourself - Kendini Tekrar Etme
            //değer tutucu , alias
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi=false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


    

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Sisteme Giriş Yapıldı");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapılmadı");
            }

            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
