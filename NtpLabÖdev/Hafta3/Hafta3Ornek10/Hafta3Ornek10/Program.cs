using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ornek10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Bir Tamsayı Giriniz.");
            sayı = Convert.ToInt32(Console.ReadLine());

            for (int bit = 32; bit >=1; bit--)
            {
                Console.Write("{0}", (sayı >> bit - 1) & 1);

            }
            Console.WriteLine();
        }
    }
}
