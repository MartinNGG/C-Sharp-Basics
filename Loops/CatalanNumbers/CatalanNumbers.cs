using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter an integer in the range (1 < n < 100):");
        int n = int.Parse(Console.ReadLine());
        BigInteger Factorial2N = 1;
        BigInteger FactorialN = 1;
        BigInteger FacturialNPlus1 = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            Factorial2N *= i;
            if (i <= n)
            {
                FactorialN *= i;
            }
        }
        for (int i = 1; i <= n + 1; i++)
        {
            FacturialNPlus1 *= i;
        }
        Console.WriteLine("{0}", Factorial2N / (FactorialN *
        FacturialNPlus1));
    }
}