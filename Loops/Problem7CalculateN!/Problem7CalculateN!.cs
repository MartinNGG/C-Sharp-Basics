using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


class Problem7CalculateN
{
    static void Main()
    {
        Console.WriteLine("Enter two integers n and k: ");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        int factorialK = 1;
        BigInteger factorialNK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        for (int i =1; i <=n-k; i++)
        {
            factorialNK *= i;
        }
        Console.WriteLine("{0}", factorialN /  (factorialK * (factorialNK)));
    }
}
