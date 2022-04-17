using System;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            char[] charToReplace = { '-', ',', '.', '!', '?' };
            using StreamReader reader = new StreamReader("./text.txt");
            int counter = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {

                    ReplaceAll(charToReplace, '@', line);
                    Reverse(line);
                }
            }
        }

         static string Reverse(string line)
        {
            StringBuilder sb = new StringBuilder();
            string[] word = line.Split(' ').ToArray();

            for(int i = 0; i < word.Length; i++)
            {
                sb.Append(word[word.Length - i - 1]);
                sb.Append(' ');

            }
            return sb.ToString().TrimEnd();
        }

        static string ReplaceAll(char[] charToReplace, char v, string line)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char currSymbol = line[i];

                if (charToReplace.Contains(currSymbol))
                {
                    sb.Append('@');
                }
                else
                {
                    sb.Append(currSymbol);
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
