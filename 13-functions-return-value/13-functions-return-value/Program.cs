using System;

namespace _13_functions_return_value
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();

                if (name == "")
                {
                   // WriteTryAgain();
                    name = WriteTryAgain();
                }

                Console.WriteLine("What is your age?");
                var age = Console.ReadLine();

                if (age == "")
                {
                    //WriteTryAgain();
                    age = WriteTryAgain();
                }

                Console.WriteLine("What pet do you have??");
                var pet = Console.ReadLine();

                if (pet == "")
                {
                    //WriteTryAgain();
                    pet = WriteTryAgain();
                }
               
                            Console.WriteLine("your name is {0}", name);
                            Console.WriteLine("your age is {0}", age);
                            Console.WriteLine("you have {0}", pet);
                
            }

            static string WriteTryAgain()
            {
                Console.WriteLine("You didn't enter any values...");
                return Console.ReadLine();
            }
        }
    }
}
