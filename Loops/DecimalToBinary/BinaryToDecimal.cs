using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter binary number: ");
            string n = Console.ReadLine();
            long bin = Convert.ToInt64(n, 2);
            Console.WriteLine("Demical is: " + bin);
        }
    }
}
