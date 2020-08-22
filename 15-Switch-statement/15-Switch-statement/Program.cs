using System;

namespace _15_Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many years of exp do you have?");
            var years = int.Parse( Console.ReadLine());

            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperienced Developers");
                    break;
                case 1:
                    Console.WriteLine("Jr Developers");
                    break;
                case 2:
                    Console.WriteLine("Mid Developers");
                    break;
                case 3:
                    Console.WriteLine("Sr Developers");
                    break;
                case 4:
                    Console.WriteLine("Guru Developers");
                    break;
                default:
                    Console.WriteLine("Super Developer");
                    break;


            }

        }
    }
}

/*
 *         {
            Console.WriteLine("how many years of exp do you have?");

            var years = int.Parse( Console.ReadLine());
            if (years == 0)
                Console.WriteLine("Inexperienced Developers");
           else if (years == 1)
                Console.WriteLine("Jr Developers");
            else if (years == 2)
                Console.WriteLine("Mid level Developers");
            else if (years == 3)
                Console.WriteLine("Sr level Developers");
            else 
                Console.WriteLine("Guru level Developers");
        }
 * 
*/