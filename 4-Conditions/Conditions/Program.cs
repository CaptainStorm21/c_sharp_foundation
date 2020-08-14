using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            if (month == "march")
            {
                Console.WriteLine("you are an Aries");
            }
            else if (month == "November")
             {
                Console.WriteLine("you are Scorpio");
            }
           else if (month == "January")
            {
                Console.WriteLine("you are Capricorn");
            }
            else
            {
                Console.WriteLine("your zodiac doesnt exist");
            }
        }
    }
}
