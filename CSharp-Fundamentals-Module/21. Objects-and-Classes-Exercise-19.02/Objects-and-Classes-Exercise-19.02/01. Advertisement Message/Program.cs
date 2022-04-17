﻿using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new[]
            {
                "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
            };

            string[] authors = new[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities = new[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            int n = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);

                int eventIndex = random.Next(0, events.Length);

                int authorsIndex = random.Next(0, authors.Length);

                int citiesIndex = random.Next(0, cities.Length);

                string message = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorsIndex]} - {cities[citiesIndex]}";

                Console.WriteLine(message);
            }
        }
    }
}
