using System;

namespace _12_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {
                WriteTryAgain();
                name = Console.ReadLine();
            }

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                WriteTryAgain();
                age = Console.ReadLine();
            }

            Console.WriteLine("What pet do you have??");
            var pet = Console.ReadLine();

            if (pet == "")
            {
                WriteTryAgain();
                pet = Console.ReadLine();
            }
/*
            Console.WriteLine("your name is {0}", name);
            Console.WriteLine("your age is {0}", age);
            Console.WriteLine("you have {0}", pet);
*/
        }

        static void WriteTryAgain ()
        {
            Console.WriteLine("You didn't enter any values...");
        }

    }
}
