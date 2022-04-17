﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] parts = line.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Add")
                {
                    string cardName = parts[1];

                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        Console.WriteLine("Card successfully added");
                        cards.Add(cardName);
                    }
                }
                else if (command == "Remove")
                {
                    string cardName = parts[1];
                    if (cards.Contains(cardName))
                    {
                        Console.WriteLine("Card successfully removed");
                        cards.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(parts[1]);

                    if(index>=0&& index < cards.Count)
                    {
                        Console.WriteLine("Card successfully removed");
                        cards.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(parts[1]);
                    string cardName = parts[2];

                    if (!(index >= 0 && index < cards.Count))
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if ((index >= 0 && index < cards.Count) && (cards.Contains(cardName)))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else
                    {
                        cards.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }
            Console.WriteLine(string.Join(", ",cards));
        }
    }
}
