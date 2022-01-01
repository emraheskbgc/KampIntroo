using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
     class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "c# Kursu";
            string kurs2 = "java Kursu";

            string[] kurslar = new string[] { "c# Kursu", "java Kursu","python kursu","c++" };
           
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfa sonu");
            Console.WriteLine("foreach başlangıcı");

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
