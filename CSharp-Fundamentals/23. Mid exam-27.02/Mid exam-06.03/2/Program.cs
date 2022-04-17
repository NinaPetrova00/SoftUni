using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cookies = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Eat")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                string biscuit = parts[1];

                if (command == "Update-Any")
                {
                    if (cookies.Contains(biscuit))
                    {
                        for (int i = 0; i < cookies.Count; i++)
                        {
                            if (cookies[i] == biscuit)
                            {
                                cookies[i] = "Out of stock";
                            }
                        }
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(parts[2]);

                    if (index < cookies.Count)
                    {
                        for (int i = 0; i < cookies.Count; i++)
                        {
                            if (i == index)
                            {
                                cookies[i] = biscuit;
                            }
                        }
                    }
                }
                else if (command == "Update-Last")
                {
                    int lastIndex = cookies.Count - 1;

                    cookies.RemoveAt(lastIndex);
                    cookies.Add(biscuit);

                }
                else if (command == "Rearrange")
                {
                    if (cookies.Contains(biscuit))
                    {
                       int currentIndex= cookies.IndexOf(biscuit);

                        cookies.RemoveAt(currentIndex);

                        cookies.Add(biscuit);
                    }
                }
            }

            for (int i = 0; i < cookies.Count; i++)
            {
                string notAllowed = "Out of stock";

                string cuurentCookie = cookies[i];

                if (cookies[i] == notAllowed)
                {
                    cookies.Remove(cuurentCookie);
                }
            
            }

         Console.WriteLine(string.Join(" ",cookies));
        }
    }
}
