using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> exercises = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "course start")
                {
                    break;
                }

                string[] text = line.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string command = text[0];

                string lessonTitle = text[1];

                if (command == "Add")
                {
                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(text[2]);

                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Insert(index, lessonTitle);
                    }

                }
                else if (command == "Remove")
                {
                    if (lessons.Contains(lessonTitle))
                    {
                        lessons.Remove(lessonTitle);
                    }
                }
                else if (command == "Swap")
                {
                    string lessonTitleTwo = text[2];
                    
                  /*  if ((lessons.Contains(lessonTitle)) && (lessons.Contains(lessonTitleTwo)))
                    {
                        string temp = lessonTitle;
                        int index1 = lessons.IndexOf(lessonTitle);
                        int index2 = lessons.IndexOf(lessonTitleTwo);

                        lessons[index1] = lessonTitleTwo;
                        lessons[index2] = temp;
         
                    }*/
                 Swap(lessons, lessonTitle, lessonTitleTwo);
                }
                else if (command == "Exercise")
                {

                    AddExercise(lessons, exercises, lessonTitle);

                    /*
                    string exerciseCommand2 = text[0];
                    string dash = "-";
                    string exercise = lessonTitle +dash+ command;

                    if (!lessons.Contains(lessonTitle))
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add(exercise);
                    }*/

                }

            }
            int n = 1;

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{n}.{lessons[i]}");
                n++;
            }

        }
        private static void Swap(List<string> schedule, string lesson1, string lesson2)
        {
            
            if ((schedule.Contains(lesson1)) && (schedule.Contains(lesson2)))
            {
                string temp = lesson1;
                int index1 = schedule.IndexOf(lesson1);
                int index2 = schedule.IndexOf(lesson2);
                schedule[index1] = lesson2;
                schedule[index2] = temp;
            }
        }

        private static void AddExercise(List<string>lessons,List<string>exercises,string lessonTitle)
        {
            if (lessons.Contains(lessonTitle) &&
                       (!lessons.Contains($"{lessonTitle}-Exercise")))
            {
                exercises.Add($"{lessonTitle}-Exercise");
            }
            else if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
                exercises.Add($"{lessonTitle}-Exercise");
            }
        }

    }
}
