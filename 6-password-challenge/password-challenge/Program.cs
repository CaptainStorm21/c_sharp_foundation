using System;

namespace password_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the password");
            var passcode = Console.ReadLine();

            if (passcode == "secret")
            {
                Console.WriteLine("Your password was accepted");
            } else if (passcode != "secret")
            {
                Console.WriteLine("Your password was not accepted!");
            }
        }
    }
}
