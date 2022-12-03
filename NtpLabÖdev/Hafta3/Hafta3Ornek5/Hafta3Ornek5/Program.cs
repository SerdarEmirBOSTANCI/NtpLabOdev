using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int secim;

            do
            {
                Console.WriteLine("İşlemler \n========");
                Console.WriteLine("1 - Toplama");
                Console.WriteLine("2 - Çıkarma");
                Console.WriteLine("3 - Çarpma");
                Console.WriteLine("4 - Bolme");
                Console.WriteLine("0 - Toplama");
                Console.Write("İşleminizi Seçin:");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: Console.WriteLine("Toplama İşlemi Seçildi."); break;
                    case 2: Console.WriteLine("Çıkarma İşlemi Seçildi."); break;
                    case 3: Console.WriteLine("Çarpma İşlemi Seçildi."); break;
                    case 4: Console.WriteLine("Bolme İşlemi Seçildi."); break;
                    case 5: Console.WriteLine("Çıkış Seçildi."); break;
                    default: Console.WriteLine("Yanlış seçim."); break;

                }

            } while (secim != 0);
        }
    }
}
