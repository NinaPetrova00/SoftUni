using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input1 = Console.ReadLine();
                string[] parts = input1.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (input1.Contains("Add"))
                {
                    string cardName = parts[1];

                    if (list.Contains(cardName))
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        list.Add(cardName);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (parts[0] == "Remove At")
                {
                    int index = int.Parse(parts[1]);
                    if (index < 0 || index > list.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        list.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }

                }
                else if (parts[0] == "Remove")
                {
                    string cardName = parts[1];

                    if (list.Contains(cardName))
                    {
                        list.Remove(cardName);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (input1.Contains("Insert"))
                {
                    int index = int.Parse(parts[1]);
                    string cardName = parts[2];
                    if (index < 0 || index > list.Count - 1)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                    else
                    {
                        if (list.Contains(cardName))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            list.Insert(index, cardName);
                            Console.WriteLine("Card successfully added");
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
