using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

         
            Console.WriteLine(Middle(text));
        }

        static string Middle(string text)
        {

            if (text.Length % 2 == 0)
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }
            else //odd length
            {
                return $"{text[(text.Length- 1)/2]}";
            }

        }
    }
}
