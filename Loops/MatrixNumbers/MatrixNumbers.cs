using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNumbers
{
    class MatrixNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countCol = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < 2 * n; j++)
                {
                    if (countCol <= n)
                    {
                        Console.Write(j + " ");
                        countCol++;
                    }
                }
                Console.WriteLine();
                countCol = 1;
            }
        }
    }
}