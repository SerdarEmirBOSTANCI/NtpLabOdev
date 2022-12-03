﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                for (; ; )
                {
                    try
                    {
                        Console.Write("Lütfen çıkmak için 0 ya da 1 girin: ");
                        string a = Console.ReadLine();
                        if (a == "0" || a == "1") break;
                        else
                        {
                            IndexOutOfRangeException nesne = new
                            IndexOutOfRangeException("Başa dönüldü");
                            nesne.HelpLink = "http://tr.wikibooks.org";
                            throw nesne;
                        }
                    }
                    catch (IndexOutOfRangeException nesne)
                    {
                        Console.WriteLine(nesne.Message); continue;
                    }
                }
            
        }
    }
}
