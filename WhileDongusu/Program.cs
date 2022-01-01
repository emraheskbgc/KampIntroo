using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 100;

            while (number >=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("döngü bitti");
        }
    }
}
