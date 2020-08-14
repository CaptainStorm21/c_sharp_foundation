using System;

namespace for_loop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // count from 1 to 10 and then back repeat 5 times
            // cannot use if

            for (int i_outerloop = 1; i_outerloop <= 5; i_outerloop++)
            {
                Console.WriteLine("Number of loop: " + i_outerloop);
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}