using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryy
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string bin = Convert.ToString(n, 2);
            Console.WriteLine(bin);
        }
    }
}
