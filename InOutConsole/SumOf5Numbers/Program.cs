using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers in 1 line: ");
            string[] nums = Console.ReadLine().Split();
            double a = double.Parse(nums[0]);
            double b = double.Parse(nums[1]);
            double c = double.Parse(nums[2]);
            double d = double.Parse(nums[3]);
            double e = double.Parse(nums[4]);
            Console.WriteLine("Sum of numbers is: ");
            double sum = a + b + c + d + e;
            Console.WriteLine(sum);

        }
    }
}
