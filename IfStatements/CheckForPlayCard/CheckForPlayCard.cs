using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            Console.Write("Enter card: ");
            string card = (Console.ReadLine());
            if (card == "2" || card == "3" || card == "4" || card == "5" || card == "6" || card == "7" || card == "8" || card == "9" || card == "10" || card == "J" || card == "Q" || card == "K" || card == "A")
            Console.WriteLine("yes");
            else
            {
            Console.WriteLine("no");
            }
        }
    }
}
