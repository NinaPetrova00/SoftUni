using System;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Done")
                {
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Change")
                {
                    string ch = parts[1];
                    string replacement = parts[2];

                    while (text.Contains(ch))
                    {
                        text = text.Replace(ch, replacement);
                    }

                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string str = parts[1];

                    bool flag = false;

                    if (text.Contains(str))
                    {
                        flag = true;
                    }
                    Console.WriteLine(flag);
                }
                else if (command == "End")
                {
                    string str = parts[1];
                    bool flag = text.EndsWith(str);

                    Console.WriteLine(flag);

                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char ch = char.Parse(parts[1]);

                    int index = text.IndexOf(ch);

                    Console.WriteLine(index);

                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);

                    string substring = text.Substring(startIndex, endIndex - startIndex);
                   
                    
                }
            }
        }
    }
}
