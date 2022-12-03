using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta9Ornek2
{
    class Kedi
    {
    protected int ayakSayisi = 4;
     public void yakalaAv()
        {
    Console.WriteLine("Kedi sinifi Av yakaladi");
        }
    } 
    class Kaplan : Kedi
    {
    public Kaplan()
        {
    Console.WriteLine("Ayak Sayisi = " + ayakSayisi);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();
            kp.yakalaAv();
        }
    }
}
