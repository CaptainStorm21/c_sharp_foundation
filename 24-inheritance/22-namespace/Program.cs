﻿using System;
using System.Collections.Generic;

namespace _22_namespace
{
    internal class Program
    {
        private static void Import()
        {
            var ImportedStudent = new Student("Mary", 90, "Birthday", "address", 90909099);
            Console.WriteLine(ImportedStudent.Name);
            Console.WriteLine(ImportedStudent.Grade);
        }

        private static void Main(string[] args)
        {
            var mathStudents = new List<Student>();
            var adding = true;

            while (adding)
            {
                //test Import();
                var newStudent = new Student();

                newStudent.Name = Util.Console.Ask("Student Name: ");
                newStudent.Grade = int.Parse(Util.Console.Ask("Student Grades: "));
                newStudent.Address = Util.Console.Ask("Student Address: ");
                newStudent.Birthday = Util.Console.Ask("Student Birthday: ");
                newStudent.Phone = int.Parse(Util.Console.Ask("Student Phone: "));

                mathStudents.Add(newStudent);
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
        private class Member
        {
            public string Address;
            public string Name;
            protected int phone;

            public int Phone
            {
                set
                {
                    phone = value;
                }
            }
        }

        private class Student : Member
        {
            static public int Count = 0;
            public string Birthday;
            public int Grade;
            public Student()
            {
            }

            public Student(string name, int grade, string birthday, string address, int phone)
            {
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Phone = phone;
                Address = address;
            }
        }

        private class Teacher:Member
        {
            public string Subject;
        }
    }
}