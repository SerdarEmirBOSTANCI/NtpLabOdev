using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Ornek5
{
    internal class Program
    {
        struct Ogrenci
        {
            public int Numara;
            public string Ad;
            public string Soyad;
        }

        static void Main(string[] args)
        {
            Ogrenci ogrl = new Ogrenci();
            ogrl.Numara = 123;
            ogrl.Ad = "Ali";
            ogrl.Soyad = "Türk";
            Ogrenci ogr2 = ogrl;
            ogr2.Numara = 456;
            Console.WriteLine("{0} {1} {2}", ogrl.Numara, ogrl.Ad, ogrl.Soyad);
            Console.WriteLine("{0} {1} {2}", ogr2.Numara, ogr2.Ad, ogr2.Soyad);




        }
    }
}
