using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Generate")
                {
                    break;
                }

                string[] parts = line.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "Contains")
                {
                    string substring = parts[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                if (command == "Flip")
                {
                    string casing = parts[1];

                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);

                    string substring = rawActivationKey.Substring(startIndex, endIndex-startIndex);

                    if (casing == "Upper")
                    {

                        rawActivationKey = rawActivationKey.Replace(substring, substring.ToUpper());
                    }
                    else if (casing == "Lower")
                    {
                        rawActivationKey = rawActivationKey.Replace(substring, substring.ToLower());
                    }
                    Console.WriteLine(rawActivationKey);
                   
                }
                if (command == "Slice")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                                    
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex-startIndex);

                    Console.WriteLine(rawActivationKey);
                   
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
