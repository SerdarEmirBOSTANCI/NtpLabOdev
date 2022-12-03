using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10Ornek5
{
    delegate void OlayYoneticisi();
    internal class Program
    {
        static void Main(string[] args)
        {
            Program nesne = new Program();
            nesne.Olay += new OlayYoneticisi(Metot); 
            nesne.Olay();
        }
        static void Metot() { Console.WriteLine("Butona tıklandı."); }
        event OlayYoneticisi Olay;
    }
}
