using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter company adress: ");
            object adress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            object phoneNumber = Console.ReadLine();
            Console.Write("Enter fax number: ");
            object faxNumber = Console.ReadLine();
            if (faxNumber == string.Empty)
            {
                faxNumber = "(no fax)";
            }
            Console.Write("Enter website: ");
            string website = Console.ReadLine();
            Console.Write("Enter manager's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter manager's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter manager's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter manager's phone number: ");
            object mangNumber = Console.ReadLine();
            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Address:{0}", adress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax: {0}", faxNumber);
            Console.WriteLine("Web site: {0}", website);
            Console.Write("Manager: {0} ", firstName);
            Console.Write("{0}", lastName);
            Console.WriteLine("(age: {0}", age);
            Console.WriteLine("tel. {0})", mangNumber);

        }
    }
}
