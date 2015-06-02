using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Biggest number is: " + a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("Biggest number is: " + b);
            }
            if (c > a && c > b)
                Console.WriteLine("Biggest number is: " + c);
        }
    }
}
