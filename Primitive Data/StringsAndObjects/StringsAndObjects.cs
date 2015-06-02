using System;

namespace StringsAndObjects
{
	class StringsAndObjects
	{
		public static void Main (string[] args)
		{
			string hi = "Hello";
			string wd = "World";
			object combine = hi + " " + wd;
            string result = (string)combine;
			Console.WriteLine (result);
		}
	}
}
