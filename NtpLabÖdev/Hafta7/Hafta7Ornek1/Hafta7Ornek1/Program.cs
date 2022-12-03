using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7Ornek1
{
    class Deneme
    {
        public int a;
        public int b;
        public Deneme(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Topla (int x, int y)
        {
            return x + y;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Hafta7Ornek1.Deneme d = new Hafta7Ornek1.Deneme(1, 2);
            Console.WriteLine(d.a);
            Console.WriteLine(Hafta7Ornek1.Deneme.Topla(2,3));
        }
    }
}
