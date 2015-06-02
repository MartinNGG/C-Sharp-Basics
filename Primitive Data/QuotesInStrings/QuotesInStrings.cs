using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string quotes = @"The ""use"" of quotations causes difficulties.";
            string quotes2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(quotes);
            Console.WriteLine(quotes2);
        }
    }
}
