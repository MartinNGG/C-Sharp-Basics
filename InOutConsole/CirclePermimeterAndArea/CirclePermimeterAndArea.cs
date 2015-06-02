using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePermimeterAndArea
{
    class CirclePermimeterAndArea
    {
        static void Main(string[] args)
        {
             Console.Write("Enter radius: ");
             double r = double.Parse(Console.ReadLine());
             double area = Math.PI * Math.Pow(r, 2);
             double perimeter = 2 * Math.PI * r;
             Console.WriteLine("Perimiter is: {0:F2}", perimeter);
             Console.WriteLine("Area is: {0:F2}", area);
        }
    }
}
