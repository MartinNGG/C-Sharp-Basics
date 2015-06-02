using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("{0}", a);
            Console.WriteLine("{0}", b);
            b = b - a;
            a = a + b;
                Console.WriteLine("{0}", a);
                Console.WriteLine("{0}", b);
        }
    }
}
