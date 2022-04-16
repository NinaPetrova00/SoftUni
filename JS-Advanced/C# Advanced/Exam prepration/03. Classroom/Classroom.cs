<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Capacity <= Count)
            {
                return $"No seats in the classroom";
            }
            students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {

            if (students.Exists(x => x.FirstName == firstName && x.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            return $"Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> studentSubject = students
                .Where(x => x.Subject == subject)
                .ToList();

            if (studentSubject.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Subject: {subject}");
                stringBuilder.AppendLine($"Students:");

                foreach (Student student in studentSubject)
                {
                    stringBuilder.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return stringBuilder.ToString().TrimEnd();
            }
            return $"No students enrolled for the subject";
        }

        public int GetStudentsCount() => Count;
        public Student GetStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return currentStudent;
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    public class Classroom
    {
        List<Student> students;
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();
        }
        public int Capacity { get; set; }
        public int Count => students.Count;

        public string RegisterStudent(Student student)
        {
            if (Capacity <= Count)
            {
                return $"No seats in the classroom";
            }
            students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {

            if (students.Exists(x => x.FirstName == firstName && x.LastName == lastName))
            {
                students.Remove(students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName));
                return $"Dismissed student {firstName} {lastName}";
            }
            return $"Student not found";
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> studentSubject = students
                .Where(x => x.Subject == subject)
                .ToList();

            if (studentSubject.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Subject: {subject}");
                stringBuilder.AppendLine($"Students:");

                foreach (Student student in studentSubject)
                {
                    stringBuilder.AppendLine($"{student.FirstName} {student.LastName}");
                }
                return stringBuilder.ToString().TrimEnd();
            }
            return $"No students enrolled for the subject";
        }

        public int GetStudentsCount() => Count;
        public Student GetStudent(string firstName, string lastName)
        {
            Student currentStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

            return currentStudent;
        }

    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
