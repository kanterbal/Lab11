using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uravnenie;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Uravn uravnenie = new Uravn(k, b);
            uravnenie.Root();
            Console.ReadKey();
        }
    }
}
