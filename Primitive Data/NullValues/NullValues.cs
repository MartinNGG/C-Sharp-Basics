using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class NullValues
    {
        static void Main(string[] args)
        {
            int? value1 = null;
            double? value2 = null;
            Console.WriteLine("This is the integer with value of Null: " + value1);
            Console.WriteLine("This is a double with the value of Null: " + value2);
            value1 = 10;
            value2 = 2.5;
            Console.WriteLine("This is the integer with value of 10 : " + value1);
            Console.WriteLine("This is the double with the value of 2.5: " + value2);
        }
    }
}
