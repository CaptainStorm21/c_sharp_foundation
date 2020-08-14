using System;
using System.Net.Http.Headers;

namespace _10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // an array for students
            var studentsGrades = new int[10];
            studentsGrades[0] = 10;
            studentsGrades[1] = 20;
            studentsGrades[5] = 60;

            Console.WriteLine("Student #5's score was " + studentsGrades[5]);

            var studentIDs = new int[5] { 30, 31, 32, 33, 34 };
            Console.WriteLine("Student Id is " + studentIDs[2]);

            var studentNames = new string[] { "Alex", "Mary", "Marina", "Polly", "Walter"};
            Console.WriteLine("Student's name is " + studentNames[2]);
        }
    }
}
