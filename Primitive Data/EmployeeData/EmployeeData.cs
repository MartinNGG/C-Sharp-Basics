using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string first = "Ivan";
            string last = "Ivanov";
            byte age = 50;
            char gen = 'm';
            long ID = 8306112507;
            int EmNumber = 27569999;
            Console.WriteLine("Name: " + first + " " + last);
            Console.WriteLine("Age: " + age + " years old");
            Console.WriteLine("Gender: " + gen);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Employee Number: " + EmNumber);
        }
    }
}
