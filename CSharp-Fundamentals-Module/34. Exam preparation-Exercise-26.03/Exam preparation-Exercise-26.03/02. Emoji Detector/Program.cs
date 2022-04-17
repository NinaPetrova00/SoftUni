using System;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex digitsRegex = new Regex(@"\d");
            Regex emojiRegex = new Regex(@"(::([A-Z][a-z]{2,})::)|(\*\*([A-Z][a-z]{2,})\*\*)");

            string text = Console.ReadLine();

            MatchCollection allDigits = digitsRegex.Matches(text);

            long threshold = CalculateTreheshold(allDigits);

            Console.WriteLine($"Cool threshold: {threshold}");

            MatchCollection emojiMathces = emojiRegex.Matches(text);

            Console.WriteLine($"{emojiMathces.Count} emojis found in the text. The cool ones are:");

            foreach (Match emojiMatch in emojiMathces)
            {
                string emojiText = emojiMatch.Groups[2].Value;

                if (emojiText == string.Empty)
                {
                    emojiText = emojiMatch.Groups[4].Value;
                }

                long coolness = GetAsciiSum(emojiText);

                if (coolness > threshold)
                {
                    Console.WriteLine($"{emojiMatch.Value}");
                }
            }
        }

        private static long GetAsciiSum(string text)
        {
            long result = 0;

            foreach (char letter in text)
            {
                result += letter;
            }

            return result;
        }

        private static long CalculateTreheshold(MatchCollection digits)
        {
            long result = 1;
            foreach (Match digit in digits)
            {
               result*= int.Parse(digit.Value);
            }

            return result;
        }
    }
}
