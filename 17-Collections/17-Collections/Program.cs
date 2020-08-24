using System;
using System.Collections.Generic;

namespace _17_Collections
{
    class Program
    {

        static void Main(string[] args)
        {


            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;


            while (adding)
            {
                Console.WriteLine("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.WriteLine("Student Grades: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add Another Student? Yes/No");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }


            }


            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

        }
    }
}
