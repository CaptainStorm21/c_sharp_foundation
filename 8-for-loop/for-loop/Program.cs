using System;
using System.Threading;

namespace for_loop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var count = 1; 

            for (int count = 1; count <=10; count++)
            {
                Console.WriteLine(count);
            }

            /*
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }
            */
        }
    }
}