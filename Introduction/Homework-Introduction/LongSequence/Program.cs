using System;

namespace PrintSequence
{
    class PrintSequence
    {
        public static void Main(string[] args)
        {

            for (int i = 2; i < 1000; i++)

                if (i % 2 == 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(-i + ", ");
                }
        }
    }
}