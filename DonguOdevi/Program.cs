using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguOdevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Id = 1;
            product1.ProductName = "Bcaa";
            product1.ProductDeatils = "Kas yıkımı önleme";

            Products product2 = new Products();
            product2.Id = 2;
            product2.ProductName = "whey";
            product2.ProductDeatils = "protein tozu";

            Products product3 = new Products();
            product3.Id = 3;
            product3.ProductName = "Arjinin";
            product3.ProductDeatils = "Pump Etkisi";

            Products[] products = new Products[] {product1,product2,product3 };
            

            Console.WriteLine("----Foreach Kullanımı-----");

            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName+" "+item.ProductDeatils);
            }
            Console.WriteLine("----Foreach bitti------");
            Console.WriteLine("----For Kullanımı------");
           
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName+" "+products[i].ProductDeatils);
            }
            Console.WriteLine("------For Bitti------");
            Console.WriteLine("------While Kullanımı------");
            int sup = 0;
            while (sup<3)
            {
                Console.WriteLine(products[sup].ProductName+" "+ products[sup].ProductDeatils);
                sup++;
            }
            Console.WriteLine("-------While Bitti--------");
        }
    }
}
