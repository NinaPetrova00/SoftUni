using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    { 
        static void Main(string[] args)
        {
           

            Dictionary<char, int> counts = new Dictionary<char, int>();

            string word = Console.ReadLine();


            foreach (char letter in word)
            {
                if (letter ==' ')
                {
                    continue;
                }
                if (counts.ContainsKey(letter))
                {
                    counts[letter]++;
                }
                else
                {
                    counts.Add(letter, 1);
                }
            }

        
            foreach (var element in counts)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
