﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, t, toplam, n1, n2;
            Console.Write("Aralık Başlangıcı :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aralık Sonu       :");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 <= n2)
            {
                for(k = n1; k < n2; k++)
                {
                    toplam = 0;
                    for ( t = 1; t <= k; t++) { if (k % t == 0) toplam = toplam + t; }
                    if(toplam == k + 1) Console.Write(k);
                }

            }
            else
            {
                Console.WriteLine("Geçerli Bir Aralık Giriniz...");
            }
        }
    }
}
