using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5Ornek6
{
    internal class Program
    {
        public int En = 20; public int Boy = 5;
        public int Alan()
        { int Alan = En * Boy; return Alan; }

    static void Main(string[] args)
        {
            Console.WriteLine("***************");
            Console.WriteLine("En:{0,5}", En);
            Console.WriteLine("Boy:{0,5}", Boy);
            Console.WriteLine("Alan:{0,5}", Alan());
            Console.WriteLine("***************");

        }
            
         
        
    }
}
