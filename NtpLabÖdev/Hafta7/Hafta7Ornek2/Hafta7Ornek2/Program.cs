using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7Ornek2
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace isimalan
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}
internal class Program
    {
        static void Main(string[] args)
        {
        Hafta7Ornek2.Deneme d1 = new Hafta7Ornek2.Deneme();
        isimalan.Deneme d2 = new isimalan.Deneme();
        }
    }

