using System;

namespace _16_Student_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students are in your class");
            var studentCount = int.Parse(Console.ReadLine());

            //we know the num of students


            var studentNames= new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i<studentCount; i++)
            {
                Console.WriteLine("Student Name: ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student Grades: ");
                studentGrades[i] =int.Parse( Console.ReadLine());

            }

            for (int i = 0; i<studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames [i], studentGrades[i]);
            }

        }      
    }
}
