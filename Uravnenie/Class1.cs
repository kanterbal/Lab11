using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uravnenie
{
    public struct Uravn
    {
        public Uravn(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double k;
        public double b;

        public void Root()
        {
            Console.WriteLine("Peremennaja X = {0}", -b / k);
        }

    }
}
