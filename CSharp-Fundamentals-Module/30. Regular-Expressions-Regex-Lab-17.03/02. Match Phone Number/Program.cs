using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[359]+(\s|-)[2](\1)[0-9]{3}(\1)[0-9]{4}\b";

            var phones = Console.ReadLine();

            Regex regex = new Regex(pattern);

            var phoneMatches = regex.Matches(phones);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));

        }
    }
}
