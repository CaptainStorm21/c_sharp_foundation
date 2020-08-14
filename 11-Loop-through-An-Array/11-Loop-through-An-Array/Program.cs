using System;

namespace _11_Loop_through_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //new is to make a new instance
            var studentNames = new string[] { "Alex", "Mary", "Marina", "Polly", "Walter" };


            foreach (var item in studentNames)
            {
                Console.WriteLine("Student in the class is " + item);
            }
        }
    }
}
