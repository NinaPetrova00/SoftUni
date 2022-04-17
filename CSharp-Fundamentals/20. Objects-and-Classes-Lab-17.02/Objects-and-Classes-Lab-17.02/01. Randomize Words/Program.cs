using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int position = random.Next(words.Count);

                string word = words[i];
                words[i] = words[position];
                words[position] = word;
            }

            Console.WriteLine(string.Join('\n',words));
        }
    }
}
