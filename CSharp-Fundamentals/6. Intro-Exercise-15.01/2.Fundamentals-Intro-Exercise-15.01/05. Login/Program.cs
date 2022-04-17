using System;
using System.Linq;
namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            //   string password = string.Concat(username.Reverse());
            string password = "";
            int counter = 0;

            bool isLoggedIn = false;

            bool isblocked = false;
           
            for (int i = username.Length-1; i >=0; i--)
            {
                password += username[i];
            }


            while (isLoggedIn == false && isblocked == false)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    isLoggedIn = true;
                }
                else
                {
                    counter++;

                    if (counter > 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        isblocked = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }


        }
    }
}
