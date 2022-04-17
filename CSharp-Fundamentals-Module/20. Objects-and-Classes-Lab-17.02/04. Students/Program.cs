using System;
using System.Collections.Generic;

namespace _04._Students
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

            List<string> students = new List<string>();


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
                int age =int.Parse(parts[2]);
                string homeTown = parts[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };

                students.Add(student);

                line = Console.ReadLine();

                string filterdCity = Console.ReadLine();

                foreach (Student student in students)
                {
                    if(student.HomeTown==filterdCity)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                    }
                }

                List <Student> filteredStude   
            }
        }
    }
}
