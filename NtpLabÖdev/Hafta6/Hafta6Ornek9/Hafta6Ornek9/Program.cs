using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Ornek9
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
            String[] sabitler = Enum.GetNames(typeof(GUNLER));
            foreach (String s in sabitler)
                Console.WriteLine(s);
        }
    }
}
