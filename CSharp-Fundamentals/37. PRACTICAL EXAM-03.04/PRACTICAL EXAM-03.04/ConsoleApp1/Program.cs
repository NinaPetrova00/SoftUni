using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var pattern = @"^U\$(?<username>[A-Z][a-z]{2,})U\SP@\$(?<password>[A-Za-z]{5,}\d+)P@\$";

            Regex regex = new Regex(pattern);
            int registrationsCount = 0;
            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    string username = regex.Match(input).Groups["username"].ToString();
                    string password = regex.Match(input).Groups["password"].ToString();
                    registrationsCount++;
                    Console.WriteLine($"Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {registrationsCount}");
        }
       
    }
}
