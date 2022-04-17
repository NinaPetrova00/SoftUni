using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^U\$(?<username>[A-Z][a-z]{2,})U\SP@\$(?<password>[A-Za-z]{5,}\d+)P@\$";
          // string pattern = @"[U\$]+(?<username>[A-Z]{1}[a-z]{3,})[U\$]+[P@\$]+(?<password>[A-Za-z]{5,}\d+)[P@\$]+";
            Regex regex = new Regex(pattern);

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                Match matches = regex.Match(line);

                var username = matches.Groups["username"].Value.ToString();
                var password = matches.Groups["password"].Value.ToString();

                if (matches.Success)
                {
                    counter++;
                    Console.WriteLine($"Registration was successful");

                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {counter}");
        }
    }
}
