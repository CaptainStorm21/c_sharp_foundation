using System;

namespace Functions_takes_value
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                Console.WriteLine("What is your name?");
                var name = TryAnswer();

                Console.WriteLine("What is your age?");
                var age =  TryAnswer();

                Console.WriteLine("What pet do you have??");
                var pet = TryAnswer();

                Console.WriteLine("your name is {0}", name);
                Console.WriteLine("your age is {0}", age);
                Console.WriteLine("you have {0}", pet);

                if (pet == "dog")
                {
                    Console.WriteLine("You are a dog person");

                }
                /*

                if (age < 0 || age > 100)
                {
                    Console.WriteLine("Your entry was not valid");
                }
                */
            }


            static string TryAnswer()
            {
                var answer = Console.ReadLine();

                if (answer == "")
                {
                    Console.WriteLine("You didn't enter any values...");
                    return Console.ReadLine();
                }
                return answer;
            }
        }
    }
}