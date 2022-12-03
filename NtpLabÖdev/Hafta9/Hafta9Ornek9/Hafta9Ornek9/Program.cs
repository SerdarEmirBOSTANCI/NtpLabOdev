using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9Ornek9
{
    class A
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class B : A
    {
        public new void Metot1()
        { Metot2(); }
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }
    class Ana
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Metot1();
        }
    }
}
