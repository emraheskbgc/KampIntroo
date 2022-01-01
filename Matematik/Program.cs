using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
           
            dortIslem.Topla(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
        }
    }
}
