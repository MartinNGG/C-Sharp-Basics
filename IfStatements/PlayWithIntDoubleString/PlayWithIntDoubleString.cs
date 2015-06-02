using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
Choose your type: 
1 ---> int
2 ---> double
3 ---> string");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: Console.WriteLine("Please enter an integer: ");
                         int num = int.Parse(Console.ReadLine());
                         Console.Write(num +1);
                         Console.WriteLine();
                    break;
                case 2: Console.WriteLine("Please enter a double: "); 
                        double dob = double.Parse(Console.ReadLine());
                        Console.Write(dob + 1);
                        Console.WriteLine();
                    break;
                case 3: Console.WriteLine("Please enter a string: ");
                        string str = Console.ReadLine();
                        Console.Write(str + "*");
                        Console.WriteLine();
                    break;
            }
        }
    }
}
