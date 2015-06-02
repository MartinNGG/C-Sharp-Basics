using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5Calculate
{
    class Problem5Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers n and x:");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int Factorial = 1;
            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                Factorial *= i;
                sum += (Factorial / Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}