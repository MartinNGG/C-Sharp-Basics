using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Max(a, b);
            Console.WriteLine("Greater number is: {0}", result);
        }
    }
}
