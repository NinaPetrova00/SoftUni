using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string firstName = parts[0];
                string lastName = parts[1];
                int age = int.Parse(parts[2]);
                string homeTown = parts[3];

                Student student = students
                    .FirstOrDefault(t => t.FirstName == firstName && t.LastName == lastName);

                if (student != null)
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }
                else
                {
                    line = Console.ReadLine();

                }

                string filteredHomeTown = Console.ReadLine();

                List<Student> filteredStudent = students
                    .Where(t => t.HomeTown == filteredHomeTown)
                    .ToList();

                for (int i = 0; i < filteredStudent.Count; i++)
                {
                    Student student = filteredStudent[i];
                    Console.WriteLine();
                }

            }
        }
    }
}
