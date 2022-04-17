using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(Grade(grade));
        }

        static string Grade(double grade)
        {
            string note = null;

            if (grade >= 2.00 && grade <= 2.99)
            {
                note = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                note = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                note = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                note = "Very good";
            }
            else
            {
                note = "Excellent";
            }
            return note;
        }
    }
}
