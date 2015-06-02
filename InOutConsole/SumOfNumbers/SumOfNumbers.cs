using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers: ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
               double number = double.Parse(Console.ReadLine());
               sum = sum + number;
            }
            Console.WriteLine(sum);
            
        }
    }
}
