using System;

namespace _4_input_output_survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("Where do you live?");
            var city = Console.ReadLine();

            Console.Write("Your name is : {0}", name + "\n");
            Console.WriteLine("You live in {0}", city);
            Console.WriteLine("You are {0}", age);
        }
    }
}
