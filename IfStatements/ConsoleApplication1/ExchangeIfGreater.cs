using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b + " " + a);
            }
            else
                Console.WriteLine(a + " " + b);
            {
                
            }

        }
    }
}
