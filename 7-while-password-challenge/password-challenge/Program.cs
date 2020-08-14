using System;

namespace password_challenge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var passcode = "";
            while (passcode != "secret")
            {
                Console.WriteLine("What is the password?");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.WriteLine("Your password was not accepted!");
                }
            }
            Console.WriteLine("Authenticated!");
        }
    }
}