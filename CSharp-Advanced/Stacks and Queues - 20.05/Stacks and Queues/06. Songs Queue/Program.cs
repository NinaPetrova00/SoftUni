﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>();

            foreach (string song in songs)
            {
                queue.Enqueue(song);
            }

            while (queue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
                else
                {
                    int index = command.IndexOf(' ');
                    string song = command.Substring(index + 1);

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
