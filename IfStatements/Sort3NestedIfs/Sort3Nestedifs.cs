using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3NestedIfs
{
    class Sort3NestedIfs
    {
        static void Main(string[] args)
        {
            double first, second, third;
            Console.WriteLine("Enter numbers: ");
            first = double.Parse(Console.ReadLine());
            second = double.Parse(Console.ReadLine());
            third = double.Parse(Console.ReadLine());

            if (first == second && first == third)
            {
                Console.WriteLine("{0} {1} {2}", first, second, third);
            }
            if (first > second && first > third)
                if (second > third)
                {
                    Console.WriteLine("{0} {1} {2}", first, second, third);
                }
                else if (second < third)
                {
                    Console.WriteLine("{0} {1} {2}", first, third, second);
                }
                else if (second == third)
                {
                    Console.WriteLine("{0} {1} {2}", first, third, second);
                }
            if (second > first && second > third)
                if (first > third)
                {
                    Console.WriteLine("{0} {1} {2}", second, first, third);
                }
                else if (third > first)
                {
                    Console.WriteLine("{0} {1} {2}", second, third, first);
                }
                else if (third == first)
                {
                    Console.WriteLine("{0} {1} {2}", second, third, first);
                }
                if (third > first && third > second)
                if (first > second)
                {
                    Console.WriteLine("{0} {1} {2}", third, first, second);
                }
                else if (second > first)
                {
                    Console.WriteLine("{0} {1} {2}", third, second, first);
                }
                else if (second == first)
                {
                    Console.WriteLine("{0} {1} {2}", third, second, first);
                }
        }
    }
}
