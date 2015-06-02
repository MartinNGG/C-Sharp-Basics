using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class MinMaxSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number: ");
            int length = int.Parse(Console.ReadLine());
            int max = Int32.MaxValue;
            int min = Int32.MinValue;
            int sum = 0;
            double ava = 0;
            for (int i = 1; i < length; i++)
            {
                int n = int.Parse(Console.ReadLine());
                

                min = Math.Min(min, n);
                max = Math.Max(max, n);
                sum = sum + n;
                ava = sum / length;
                {
                    Console.WriteLine("Min: ", min);
                    Console.WriteLine("Max: ", max);
                    Console.WriteLine("Sum :", sum);
                    Console.WriteLine("Avarage: ", ava);
                }
            }
        }
    }
}