using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Ornek3
{
    class Sinif
    {
        public int Sayi;
        public Sinif(int sayi) { Sayi = sayi; }
        public static explicit operator int(Sinif a) { return a.Sayi; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif a = new Sinif(50);
            int b = (int)a; Console.WriteLine(b);

        }
    }
}
