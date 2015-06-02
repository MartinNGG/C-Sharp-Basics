using System;

namespace AfterTen
{
	class AfterTen
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter your age: ");
			int Age = int.Parse (Console.ReadLine());
			Console.WriteLine ("Your age after 10 years will be:{0}", Age + 10);
            Console.ReadLine();
			}
		}
	}

