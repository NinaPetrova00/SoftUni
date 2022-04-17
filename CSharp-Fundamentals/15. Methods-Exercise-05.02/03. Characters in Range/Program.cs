using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            CharInRange(first, second);
        }

        static void CharInRange(char first,char second)
        {
            char start = first;
            char end = second;

            if (second < first)
            {
                start = second;
                end = first;

            }

            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
