 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.Fiyati =2.5;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.UrunAdi = "Çilek";
            urun2.Aciklama = "Çilek Gibi Çilek";
            urun2.Fiyati = 10;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Id+" "+ item.UrunAdi+" "+item.Aciklama+" "+item.Fiyati);
            }
            Console.WriteLine("Foreach Döngü sonu");

            Console.WriteLine("------------------Metotlar-----------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}

//Don't repeat yourself --- DRY - Clean code - Best Practice = en iyi uygulama teknikleri..