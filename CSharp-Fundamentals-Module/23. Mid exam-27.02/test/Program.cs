using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> cards = Console.ReadLine()
                 .Split(":", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> deck = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Ready")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];
                string cardName = parts[1];

                if (command == "Add")
                {
                    if (cards.Contains(cardName))
                    {
                        deck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(parts[2]);

                    if (cards.Contains(cardName))
                    {
                        deck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (command == "Remove")
                {
                    if (deck.Contains(cardName))
                    {
                        deck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    string cardName2 = parts[2];

                    int index1 = deck.IndexOf(cardName);
                    int index2 = deck.IndexOf(cardName2);

                    deck.Remove(cardName);
                    deck.Remove(cardName2);

                    int tmp = index1;
                    index1 = index2;
                    index2 = tmp;

                    deck.Insert(index2, cardName2);
                    deck.Insert(index1, cardName);

                    int tempNumber=
                }
                else
                {
                    deck.Reverse();
                }

            }

            Console.WriteLine(string.Join(" ",deck));
        }
    }
}
