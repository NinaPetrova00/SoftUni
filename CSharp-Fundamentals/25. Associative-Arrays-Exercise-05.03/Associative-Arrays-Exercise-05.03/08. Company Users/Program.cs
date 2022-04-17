using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> comapanies = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = parts[0];
                string employeeID = parts[1];

                if (!comapanies.ContainsKey(company))
                {
                    comapanies.Add(company, new List<string>());
                }
                comapanies[company].Add(employeeID);
            }

            foreach (var comapany in comapanies.OrderBy(c=>c.Key))
            {
                Console.WriteLine(comapany.Key);

                List<string> uniqueEmpleyees = comapany.Value           
                     .Distinct()                   
                     .ToList();

                foreach (var employee in uniqueEmpleyees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
