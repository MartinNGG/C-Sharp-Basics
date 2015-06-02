using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            string aa = a.ToString("X");
            string aaa = Convert.ToString(a, 2).PadLeft(10, '0');
            string bb = b.ToString();
            { Console.WriteLine(); }
            Console.Write("|{0, -10} |{1,10}|", aa, aaa);
            if (b % 1 == 0)
            {
                Console.Write("{0,10}", b);
            }
            else
            {
                Console.Write("{0,10:F2}", b);
            }
            if (c % 1 == 0)
            {
                Console.Write("|{0,-10}|", c);
            }
            else
            {
                Console.Write("|{0,-10:F3}|", c);
            }
            Console.WriteLine();
        }
    }
}
