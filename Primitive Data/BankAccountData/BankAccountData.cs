using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


    class BankAccountData
    {
        static void Main(string[] args)
        {
            string first = "Ivan";
            string second = "Georgiev";
            string last = "Ivanov";
            int balance = 1000000;
            object IBAN = "BG80 BNBG 9661 1020 3456 78";
            long card1 = 1234567898765431;
            long card2 = 2314312331236423;
            long card3 = 2323644382233442;
            Console.WriteLine("Name: " + first + " " + second + " " + last );
            Console.WriteLine("Accout Balance: " + balance.ToString("##,##", new NumberFormatInfo() { NumberGroupSeparator = "," }));
            Console.WriteLine("IBAN: " + IBAN);
            Console.WriteLine("1st Credit Card: " + card1);
            Console.WriteLine("2nd Credit Card: " + card2);
            Console.WriteLine("3rd Credit Card: " + card3);
            // По принцип в задачата не се изисква да се print резултат, но така е по-лесно за проверка. :)
        }
    }

