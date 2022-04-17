using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!Characters(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (ContainsInvalidCharacters(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValid = false;

            }

            if (!DigitsCount(password))
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isValid = false;

            }

            if (isValid)
            {
                Console.WriteLine($"Password is valid");
            }


        }

        

        static bool Characters(string password)
        {

            if(password.Length>=6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsInvalidCharacters(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }


        static bool DigitsCount(string password)
        {
            int counter = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
