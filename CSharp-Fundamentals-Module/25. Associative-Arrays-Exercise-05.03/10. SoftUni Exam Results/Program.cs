using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (true)
            {
                if (line.Contains("exam finished"))
                {
                    break;
                }

                if (line.Contains("banned"))
                {

                    string[] parts = line.Split("-");

                    string bannedUser = parts[0];

                    users[bannedUser][1] = "banned";
                }
                else
                {
                    string[] parts = line.Split("-");

                    string user = parts[0];
                    string language = parts[1];
                    int score = int.Parse(parts[2]);


                    if (users.ContainsKey(user))
                    {
                        int temp = int.Parse(users[user][1]);

                        if (temp < score)
                        {
                            users[user][1] = score.ToString();
                        }
                    }
                    else
                    {
                        users.Add(user, new List<string> { language, score.ToString() });

                    }
                    if (languages.ContainsKey(language))
                    {
                        languages[language]++;
                    }
                    else
                    {
                        languages.Add(language, 1);
                    }
                }

                line = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            var sortedResult=users
                .Where(x => x.Value[1] != "banned")
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key);

            foreach (var user in sortedResult)
            {
                Console.WriteLine($"{user.Key} | {user.Value[1]}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
