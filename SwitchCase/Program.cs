using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch case, kodun akıışında belirli bir şarta göre yönlendirme yapmamızı(farklı algoritma çalışıtrmamızı/farklı operasyon
            //gerçekleştirmemizi/tetiklememizi) sağlayan yapılanmadır.
            //Switch case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılabilir
            //Sadece eşitlik durumu check edilecekse o zaman switch kullanılabilir..

            string adi = "Emrah";
            
            switch (adi)
            {
                
                case "Ayşe":
                    Console.WriteLine("Adi ayşe");

                    break;
                case "yeter":
                    Console.WriteLine("Adi yeter");

                    break;
                case "Ali":
                    Console.WriteLine("Adi ali");

                    break;
                case "Emrah":
                    Console.WriteLine("Adi Emrah");

                    break;
            }    


        }
    }
}
