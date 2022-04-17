using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordLower = word.ToLower();

                if (counts.ContainsKey(wordLower))
                {
                    counts[wordLower]++;
                }
                else
                {
                    counts.Add(wordLower, 1);
                }
            }

            foreach (var num in counts)
            {
                if (num.Value % 2 != 0)
                {
                    Console.Write(num.Key+" ");
                }
            }
        }
    }
}
