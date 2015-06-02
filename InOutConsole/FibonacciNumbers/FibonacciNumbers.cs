using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = -1;
            int secondNum = 1;
            int fibNumber;
            for (int count = 0; count < n; count++)
            {
                fibNumber = firstNum + secondNum;
                Console.Write("{0} ", fibNumber);
                firstNum = secondNum;
                secondNum = fibNumber;

                }
            }
        }
    }
