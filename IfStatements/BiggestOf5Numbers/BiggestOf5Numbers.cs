using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf5Numbers
{
    class BiggestOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a > b && a > c && a > d && a > e)
            Console.WriteLine("Biggest number is: " + a);
            if (b > a && b > c && b > d && b > e)
            Console.WriteLine("Biggest number is: " + b);
            if (c > a && c > b && c > d && c > e)
            Console.WriteLine("Biggest number is: " + c);
            if (d > a && d > b && d > c && d > e)
            Console.WriteLine("Biggest number is: " + d);
            if (e > a && e > b && e > c && e > d)
            Console.WriteLine("Biggest number is: " + e);
            }
        }
    }