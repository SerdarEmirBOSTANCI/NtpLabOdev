using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Ornek8
{
    enum GUNLER : byte
    {
        PAZARTESI,
        SALI,
        CARSAMBA,
        PERSEMBE,
        CUMA,
        CUMARTESI,
        PAZAR
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)GUNLER.PAZARTESI);
            Console.WriteLine((int)GUNLER.PAZAR);
        }
    }
}
