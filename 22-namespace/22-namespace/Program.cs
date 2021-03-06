﻿using System;
using System.Collections.Generic;

namespace _22_namespace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mathStudents = new List<Student>();
            var adding = true;

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grades: "));
                newStudent.Address = Util.Console.Ask("Student Address: ");
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone: "));

                mathStudents.Add(newStudent);
                //adding static 
                Student.Count++;
                Console.WriteLine("Student count: {0}", Student.Count);
                Console.WriteLine("Add Another Student? Yes/No");

                if (Console.ReadLine() != "y")
                {
                    adding = false;
                }
            }

            foreach (var student in mathStudents)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                Console.WriteLine("Address: {0}", student.Address);
                Console.WriteLine("Birthday: {0}", student.Birthday);
            }
        }

        internal class Student
        {
            static public int Count = 0;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public int Phone
            {
                set
                {
                    phone = value;
                    // Util.Console.Ask(phone);
                }
            }

            public void SetPhone(int number)
            {
                phone = number;
            }
        }
    }
}