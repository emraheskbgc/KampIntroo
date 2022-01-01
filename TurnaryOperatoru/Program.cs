using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaryOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operatörü
            //Bir değişkene/metoda/property'e değer atarken, eğer ki bu değer şarta göre fark edecekse satır bazlı/ tek satırda bu
            //şart kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan kalığsal operatördür.

            bool medeniHal = true;
            
         string mesaj =  medeniHal==false  ? "evlilere kampanya" : "bekarlara kampanya";
            Console.WriteLine(mesaj);

            Console.WriteLine("-------------------Diğer Örnek-----------------------");

            //birden fazla condition uygulamak
            //yaşı 25 den küçük olanlara A , 25 olanlara B ve 25 den büyük olanlara C değerini döndüren turnary operatörü oluşturalım..

            int yas = 27;

            string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            Console.WriteLine(sonuc);

            Console.WriteLine("-------------------Diğer Örnek-----------------------");

            //Kullanıcı tarafından girilen sayının aşağıdaki önergelere göre hesabını gerçekleştiren kodu geliştiriniz..
            // sayı < 3                 => sayı*5
            //sayı > 3 && sayı <9       => sayı*3
            //sayı >=9 && sayı %2 == 0  => sayı*10
            //sayı%2 == 1               =>sayı
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi =int.Parse( Console.ReadLine());



           int sonucc = sayi < 3 ? sayi * 5 : sayi > 3 && sayi < 9 ? sayi * 3 : sayi >= 9 && sayi % 2 == 0 ? sayi * 10 : sayi %2 ==1 ? sayi :-1 ;
            Console.WriteLine(sonucc);

            Console.WriteLine("---İfle Yaazım---");

            if (sayi<3)
            {
                Console.WriteLine(  sayi*5); 
            }
            else if (sayi > 3 && sayi < 9)
            {
                Console.WriteLine(sayi*3);
            }
            else if (sayi >=9 && sayi%2 ==0)
            {
                Console.WriteLine(sayi*10);
            }
            else if (sayi%2 ==1)
            {
                Console.WriteLine(sayi);
            }
            else
            {
                Console.WriteLine(-1);
            }



        }
    }
}
